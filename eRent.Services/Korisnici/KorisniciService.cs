using AutoMapper;
using eRent.Models;
using eRent.Services.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services.Korisnici
{
    public class KorisniciService
        : BaseService<KorisnikModel, Korisnik>, IKorisnici
    {
        public KorisniciService(ERentContext eRentContext, IMapper mapper)
            : base(eRentContext, mapper)
        {
        }
    }
}
