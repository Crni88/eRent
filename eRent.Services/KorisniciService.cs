using eRent.Model;
using eRent.Services.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class KorisniciService : IKorisnici
    {
        public ERentContext ERentContext { get; set; }

        public KorisniciService(ERentContext eRentContext)
        {
            ERentContext = eRentContext;
        }   

        public IEnumerable<Model.Korisnik> Get()
        {
            var result = ERentContext.Korisniks.ToList();
            List<Model.Korisnik> list = new List<Model.Korisnik>();
            foreach(var item in result)
            {
                list.Add(new Model.Korisnik()
                {
                    Email = item.Email,
                    KorisnikPrezime = item.KorisnikPrezime,
                    KorsnikIme = item.KorsnikIme,
                    KorisnikId = item.KorisnikId,
                    Rejting = item.Rejting,
                    UlogaId = item.UlogaId
                });
            }
            return list;
        }
    }
}
