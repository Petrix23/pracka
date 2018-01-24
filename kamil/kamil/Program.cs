using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<Magazyn> stos = new Stack<Magazyn>();
            //stos.Push(new Magazyn("frytki"));
            //stos.Push(new Magazyn("pieczywo"));
            //stos.Push(new Magazyn("kielbasa"));

            //while(stos.Count>0)
            //foreach (Magazyn a in stos)
            //{
            //    stos.Pop();
            //}
            // stos.Pop();




            List<Bohater> mo = new List<Bohater>();
            mo.Add(new Ork(120,12));
            mo.Add(new Ork(120, 10));

            mo.Add(new Elf(90, "10"));
            mo.Add(new Elf(80, "11"));

            Console.ReadKey();
        }
    }
}
