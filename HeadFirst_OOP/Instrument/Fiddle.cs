using HeadFirst_OOP.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public class Fiddle : Instrument
    {
        public Fiddle(string serialNumber, double price, FiddleSpec spec) : base(serialNumber, price, spec)
        {

        }
    }
}
