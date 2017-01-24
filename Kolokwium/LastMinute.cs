using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class LastMinute : Podroz
    {
        public override double KosztPoRabacie()
        {
            double x = base.KosztPoRabacie();
            x = x - (x * 0.33);
            return x;
        }
        public override string ToString(){
        string s = "Last Minute" + Environment.NewLine;
        s += base.ToString();
        return s;
        }
    }
}