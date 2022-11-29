using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRent.Services.Testni
{
    public interface iProizvodiService
    {
        IEnumerable<Proizvodi> Get();
    }
}
