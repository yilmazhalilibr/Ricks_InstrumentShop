using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP.Spec
{
    public class FiddleSpec : InstrumentSpec
    {
        private string _finish;

        private Style _style;
        public FiddleSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
        }

        public Style GetStyle()
        {
            return _style;
        }
        public bool matches(InstrumentSpec otherSpec)
        {

            if (!base.matches(otherSpec))
            {
                return false;
            }
            if (!typeof(FiddleSpec).IsInstanceOfType(otherSpec))
            {
                return false;
            }
            FiddleSpec spec = (FiddleSpec)otherSpec;
            if (_finish != spec._finish)
            {
                return false;
            }


            return true;
        }

    }
}
