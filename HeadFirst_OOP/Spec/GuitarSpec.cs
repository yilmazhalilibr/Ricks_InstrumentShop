using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public class GuitarSpec : InstrumentSpec
    {
        private int _numString;
        public GuitarSpec(Builder builder, string model, Type type, int numString, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            _numString = numString;
        }

        public bool matches(InstrumentSpec otherSpec)
        {

            if (!base.matches(otherSpec))
            {
                return false;
            }
            if (!typeof(GuitarSpec).IsInstanceOfType(otherSpec))
            {
                return false;
            }
            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (_numString != spec._numString)
            {
                return false;
            }


            return true;
        }


    }
}
