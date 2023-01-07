using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.Services.DataDB;
using System.Security.Cryptography;
using System.Text;

namespace eRent.Services.Korisnici
{
    public class KorisniciService
        : BaseCRUDService<KorisnikModel, Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>, IKorisniciService
    {
        private const string HashName = "SHA2";

        public KorisniciService(ERentContext eRentContext, IMapper mapper) : base(eRentContext, mapper)
        {
        }

        public static string GenerateSalt()
        {
            return Convert.ToBase64String(new byte[16]);
            //var buf = new byte[16];
            //(new RSACryptoServiceProvider()).GetBytes(buf);
            //return Convert.ToBase64String(buf);
        }

        public override void BeforeInsert(KorisnikInsertRequest insert, Korisnik entity)
        {
            var salt = GenerateSalt();
            entity.LozinkaSalt = salt;
            entity.LozinkaHash = GenerateHash(salt, insert.Password);
            base.BeforeInsert(insert, entity);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];
            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create(HashName);
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override IQueryable<Korisnik> AddFilter(IQueryable<Korisnik> query, KorisnikSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (!string.IsNullOrEmpty(search?.Email))
            {
                filteredQuery = filteredQuery.Where(x => x.Email == search.Email);
            }
            if (!string.IsNullOrEmpty(search?.KorsnikIme))
            {
                filteredQuery = filteredQuery.Where(x => x.KorsnikIme == search.KorsnikIme);
            }

            if (!string.IsNullOrEmpty(search?.KorsnikPrezime))
            {
                filteredQuery = filteredQuery.Where(x => x.KorsnikIme == search.KorsnikPrezime);
            }

            //if (search.Page.HasValue)
            //{
            //    //filteredQuery = filteredQuery.Take(search.Page.Value).Skip(search.PageSize.Value);
            //}
            return filteredQuery;
        }
    }
}
