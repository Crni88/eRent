using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Requests.FitPasos;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Requests.KorisnikTag;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Requests.NekretninaTag;
using eRent.Models.Requests.Payment;
using eRent.Models.Requests.Posjeta;
using eRent.Models.Requests.Rejting;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Requests.Tag;
using eRent.Models.Requests.Task;

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
            CreateMap<NekretninaTagoviInsertRequest, DataDB.NekretninaTagovi>();
            CreateMap<NekretninaTagUpdateRequest, DataDB.NekretninaTagovi>();
            //Posjeta
            CreateMap<DataDB.Posjetum, PosjetaModel>();
            CreateMap<PosjetaInsertRequest, DataDB.Posjetum>();
            CreateMap<PosjetaUpdateRequest, DataDB.Posjetum>();
            //Rejting
            CreateMap<DataDB.Rejting, RejtingModel>();
            CreateMap<RejtingInsertRequest, DataDB.Rejting>();
            CreateMap<RejtingUpdateRequest, DataDB.Rejting>();
            //Payment Request
            CreateMap<DataDB.PaymentRequest, PaymentRequestModel>();
            CreateMap<PaymentUpsertRequest, DataDB.PaymentRequest>();
            //Ugovor
            CreateMap<DataDB.Ugovor, UgovorModel>();
            CreateMap<UgovorUpsertRequest, DataDB.Ugovor>();
            //KorisnikTagovi
            CreateMap<DataDB.KorisnikTagovi, KorisnikTagoviModel>();
            CreateMap<KorisnikTagUpsertRequest, DataDB.KorisnikTagovi>();
            //Task
            CreateMap<DataDB.Task, TaskModel>();
            CreateMap<TaskInsertRequest, DataDB.Task>();
            CreateMap<TaskUpdateRequest, DataDB.Task>();
            //Mapper
            CreateMap<DataDB.FitPaso, FitPasosModel>();
            CreateMap<FitPasosInsertRequest, DataDB.FitPaso>();
            CreateMap<FitPasosUpdateRequest, DataDB.FitPaso>();
        }
    }
}
