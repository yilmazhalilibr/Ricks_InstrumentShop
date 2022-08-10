using HeadFirst_OOP.Spec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public class Bass : Instrument
    {
        public Bass(string serialNumber, double price, BassSpec spec) : base(serialNumber, price, spec)
        {

        }
    }
}
