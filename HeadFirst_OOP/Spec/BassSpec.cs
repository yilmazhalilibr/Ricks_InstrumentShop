using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP.Spec
{
    public class BassSpec : InstrumentSpec
    {
        private int _numString;
        public BassSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
        }
        public bool matches(InstrumentSpec otherSpec)
        {

            if (!base.matches(otherSpec))
            {
                return false;
            }
            if (!typeof(BassSpec).IsInstanceOfType(otherSpec))
            {
                return false;
            }
            BassSpec spec = (BassSpec)otherSpec;
            if (_numString != spec._numString)
            {
                return false;
            }


            return true;
        }
    }
}
