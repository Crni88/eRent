using AutoMapper;
using eRent.Models;

namespace eRent.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataDB.Korisnik, KorisnikModel>();
            CreateMap<DataDB.Uloga, UlogaModel>();
        }
    }
}
