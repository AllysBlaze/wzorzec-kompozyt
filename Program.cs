using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzorzec_kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            Lisc l = new Lisc("l");
            Lisc ll = new Lisc("ll");
            Lisc l1 = new Lisc("l1");
            Lisc l2 = new Lisc("l2");
            Kompozyt k = new Kompozyt("k");
            Kompozyt k2 = new Kompozyt("k2");
            Kompozyt k3 = new Kompozyt("k3");
            k.Dodaj(l);
            k.Dodaj(k2);
            k2.Dodaj(k3);
            k2.Dodaj(ll);
            k3.Dodaj(l1);
            k3.Dodaj(l2);
            k.Wypisz();
            Console.ReadKey();
            
        }
    }
}
