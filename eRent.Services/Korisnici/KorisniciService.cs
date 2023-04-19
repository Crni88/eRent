using AutoMapper;
using eRent.Models;
using eRent.Models.Exceptions;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;
using System.Data.Entity;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace eRent.Services.Korisnici
{
    public class KorisniciService
        : BaseCRUDService<KorisnikModel, Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>, IKorisniciService
    {

        public KorisniciService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public Models.KorisnikModel Login(string username, string password)
        {
            var entity = Context.Korisniks.Include("UlogaId").FirstOrDefault(x => x.Username == username);
            if (entity == null)
            {
                return null;
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);

            if (hash != entity.LozinkaHash)
            {
                return null;
            }
            return Mapper.Map<Models.KorisnikModel>(entity);    
        }


        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray);
        }


        public override void BeforeInsert(KorisnikInsertRequest insert, Korisnik entity)
        {
            var salt = GenerateSalt();
            entity.LozinkaSalt = salt;
            entity.LozinkaHash = GenerateHash(salt, insert.Password);
            entity.Username = insert.Username;
            //entity.Uloga = insert.UlogaId;
            if (Context.Korisniks.Any(k => k.Username == insert.Username))
            {
                throw new ConflictException("User with this username already exists.");
            }
            else if (Context.Korisniks.Any(k => k.Email == insert.Email))
            {
                throw new ConflictException("User with this email already exists.");
            }
            base.BeforeInsert(insert, entity);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override IQueryable<Korisnik> AddFilter(IQueryable<Korisnik> query, KorisnikSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != 0)
            {
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);            
            }

            if (!string.IsNullOrEmpty(search?.NameFTS))
            {
                filteredQuery = filteredQuery.Where(x => x.KorsnikIme.Contains(search.NameFTS) ||
                x.KorisnikPrezime.Contains(search.NameFTS) || x.Username.Contains(search.NameFTS));

            }
            if (!string.IsNullOrEmpty(search?.Email))
            {
                filteredQuery = filteredQuery.Where(x => x.Email == search.Email);
            }
            if (!string.IsNullOrEmpty(search?.Username))
            {
                filteredQuery = filteredQuery.Where(x => x.Username == search.Username);
            }
            //if (!string.IsNullOrEmpty(search?.KorsnikIme))
            //{
            //    filteredQuery = filteredQuery.Where(x => x.KorsnikIme == search.KorsnikIme);
            //}
            //if (!string.IsNullOrEmpty(search?.KorsnikPrezime))
            //{
            //    filteredQuery = filteredQuery.Where(x => x.KorisnikPrezime == search.KorsnikPrezime);
            //}

            //if (search.Page.HasValue)
            //{
            //    //filteredQuery = filteredQuery.Take(search.Page.Value).Skip(search.PageSize.Value);
            //}
            return filteredQuery;
        }
    }
}
