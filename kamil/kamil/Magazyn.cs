using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamil
{
    class Magazyn
    {
        public List<string> zamowienie;

        public Magazyn(string z)
        {
            this.zamowienie.Add(z);
        }
    }
}
