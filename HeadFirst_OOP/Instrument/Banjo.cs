using HeadFirst_OOP.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public class Banjo : Instrument
    {
        public Banjo(string serialNumber, double price, BanjoSpec spec) : base(serialNumber, price, spec)
        {

        }
    }
}
