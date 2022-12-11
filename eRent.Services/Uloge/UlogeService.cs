using AutoMapper;
using eRent.Models;
using eRent.Services.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services.Uloge
{
    public class UlogeService:BaseService<UlogaModel,Uloga> , IUlogeService
    {
        public UlogeService(ERentContext eRentContext,IMapper mapper):base(eRentContext,mapper)
        {
        }
    }
}