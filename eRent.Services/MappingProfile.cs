﻿using AutoMapper;
using eRent.Models;
using eRent.Models.Requests;

namespace eRent.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataDB.Korisnik, KorisnikModel>();
            CreateMap<DataDB.Uloga, UlogaModel>();
            CreateMap<KorisnikInsertRequest, DataDB.Korisnik>();
            CreateMap<KorisnikUpdateRequest, DataDB.Korisnik>();
        }
    }
}
