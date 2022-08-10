using HeadFirst_OOP.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public class Dobro : Instrument
    {

        public Dobro(string serialNumber, double price, DobroSpec spec) : base(serialNumber, price, spec)
        {

        }
    }
}
