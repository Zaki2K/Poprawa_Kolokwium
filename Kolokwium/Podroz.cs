using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kolokwium
{
    class Podroz : IStacja
    {
        protected Stack<Stacja> stacja = new Stack<Stacja>();
        protected double koszt = 77;

        public Podroz() { }

        public virtual double KosztPoRabacie()
        {
            double k = koszt;
            k = k - (k * 0.12);
            return k;
        }

        public override string ToString()
        {
            string s = "Podroz: " + Environment.NewLine;
            foreach (var element in stacja)
            {
                s += element.ToString();
                s += Environment.NewLine;
            }
            return s;
        }

        public void DodajStacje(string nazwa, bool oplata)
        {
            stacja.Push(new Stacja(nazwa, oplata));
            if (oplata == true) koszt += 8;
        }

        public void UsunStacje()
        {
            stacja.Pop();
        }

        public void Powrot()
        {
            stacja.Push(stacja.First());
        }
        public void ZapiszPodroz()
        {
            using (StreamWriter sw = new StreamWriter("podroze.txt"))
            {
                sw.Write(ToString());
            }
        }
    }
}