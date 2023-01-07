using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;

namespace eRent.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataDB.Uloga, UlogaModel>();
            //Korisnik
            CreateMap<DataDB.Korisnik, KorisnikModel>();
            CreateMap<KorisnikInsertRequest, DataDB.Korisnik>();
            CreateMap<KorisnikUpdateRequest, DataDB.Korisnik>();
            //Lokacija
            CreateMap<DataDB.Lokacija, LokacijaModel>();
            CreateMap<LokacijaUpsertRequest, DataDB.Lokacija>();
            //Nekretnina
            CreateMap<DataDB.Nekretnina, NekretninaModel>();
            CreateMap<NekretninaUpdateRequest, DataDB.Nekretnina>();
            CreateMap<NekretninaInsertRequest, DataDB.Nekretnina>();
            //Tag 
            CreateMap<DataDB.Tag, TagModel>();
            CreateMap<TagUpsertRequest, DataDB.Tag>();
        }
    }
}
