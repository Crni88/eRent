using eRent.Models;
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

        public IEnumerable<KorisnikModel> Get()
        {
            var result = ERentContext.Korisniks.ToList();
            List<KorisnikModel> list = new List<KorisnikModel>();
            foreach (var item in result)
            {
                list.Add(new KorisnikModel() { Email = item.Email, KorisnikPrezime = item.KorisnikPrezime, KorsnikIme = item.KorsnikIme, Rejting = item.Rejting, UlogaId = item.UlogaId });
            }
            return list;
        }
    }
}
