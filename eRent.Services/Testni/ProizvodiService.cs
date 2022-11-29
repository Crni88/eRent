using eRent.Services.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services.Testni
{
    public class ProizvodiService : iProizvodiService
    {
        public ERentContext Context { get; set; }

        public ProizvodiService(ERentContext context)
        {
            Context = context;
        }

        public List<Proizvodi> ProizvodiList =
            new List<Proizvodi>()
            { new Proizvodi(){ Id = 1, Name = "Tarik" } };

        public IEnumerable<Proizvodi> Get()
        {
            //var tmp = Context.Ulogas.ToList();
            ProizvodiList.Add(new Proizvodi() { Id = 1, Name = "Test" });
            return ProizvodiList;
        }
    }
}
