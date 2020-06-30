using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace wzorzec_kompozyt
{
    abstract class Komponent
    {
        protected string Nazwa;
        public Komponent(string nazwa)
        {
            Nazwa = nazwa;
        }
        public abstract void Wypisz();
    }
    class Kompozyt:Komponent
    {
        public Kompozyt(string nazwa) : base(nazwa) { }
        private List<Komponent> Komponenty = new List<Komponent>();
        public override void Wypisz()
        {
            Console.WriteLine("Kompozyt "+Nazwa+"\n{");
            foreach (var k in Komponenty)
                k.Wypisz();
            Console.WriteLine("}");
        }
        public void Dodaj(Komponent komponent)
        {
            Komponenty.Add(komponent);
        }
    }
    class Lisc:Komponent
    {
        public Lisc(string nazwa) : base(nazwa) { }
        public override void Wypisz()
        {
            Console.WriteLine("lisc " +Nazwa);
        }
    }
}
