using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Requests.Lokacija;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Requests.NekretninaTag;
using eRent.Models.Requests.Posjeta;
using eRent.Models.Requests.Rejting;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Requests.Tag;

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
            //NekretninaKorisnik
            CreateMap<DataDB.NekretninaKorisnik, NekretninaKorisnikModel>();
            CreateMap<NekretninaKorisnikInsertRequest, DataDB.NekretninaKorisnik>();
            CreateMap<NekretninaKorisnikUpdateRequest, DataDB.NekretninaKorisnik>();
            //Rezervacija
            CreateMap<DataDB.Rezervacija, RezervacijaModel>();
            CreateMap<RezervacijaInsertRequest, DataDB.Rezervacija>();
            CreateMap<RezervacijaUpdateRequest, DataDB.Rezervacija>();
            //NekretninaTagovi
            CreateMap<DataDB.NekretninaTagovi, NekretninaTagoviModel>();
            CreateMap<NekretninaTagoviUpsertRequest, DataDB.NekretninaTagovi>();
            //Posjeta
            CreateMap<DataDB.Posjetum, PosjetaModel>();
            CreateMap<PosjetaInsertRequest, DataDB.Posjetum>();
            CreateMap<PosjetaUpdateRequest, DataDB.Posjetum>();
            //Rejting
            CreateMap<DataDB.Rejting, RejtingModel>();
            CreateMap<RejtingInsertRequest, DataDB.Rejting>();
            CreateMap<RejtingUpdateRequest, DataDB.Rejting>();
        }
    }
}
