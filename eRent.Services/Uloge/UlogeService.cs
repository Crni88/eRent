using eRent.Services.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services.Uloge
{
    public class UlogeService : IUlogeService
    {
        public ERentContext Context { get; set; }

        public UlogeService(ERentContext eRentContext)
        {
            Context = eRentContext;
        }

        public IEnumerable<Uloga> Get()
        {
            return Context.Ulogas.ToList();
        }

        public IEnumerable<Uloga> Post(Uloga uloga)
        {
            return (IEnumerable<Uloga>)Context.Ulogas.Add(uloga);
        }
    }
}