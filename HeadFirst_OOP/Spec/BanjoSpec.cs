using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP.Spec
{
    public class BanjoSpec : InstrumentSpec
    {
        private int _numString;
        public BanjoSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {

        }
        public int GetNumString()
        {
            return _numString;
        }


        public bool matches(InstrumentSpec otherSpec)
        {

            if (!base.matches(otherSpec))
            {
                return false;
            }
            if (!typeof(BanjoSpec).IsInstanceOfType(otherSpec))
            {
                return false;
            }
            BanjoSpec spec = (BanjoSpec)otherSpec;
            if (_numString != spec._numString)
            {
                return false;
            }


            return true;
        }

    }
}
