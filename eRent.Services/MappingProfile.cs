using AutoMapper;
using eRent.Models;
using eRent.Services.DataDB;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class MappingProfile : Profile
    {
       public MappingProfile()
        {
            CreateMap < DataDB.Korisnik, KorisnikModel> ();
            CreateMap < DataDB.Uloga, UlogaModel> ();
        }
    }
}
