using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamil
{
    interface IMagazyn
    {
        int Przyjmij(string obiekt);
        bool Wydaj(int reszta);
    }
}
