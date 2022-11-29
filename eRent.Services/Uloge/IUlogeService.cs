using eRent.Services.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services.Uloge
{
    public interface IUlogeService
    {
        IEnumerable<Uloga> Get();

        IEnumerable<Uloga> Post(Uloga uloga);
    }
}
