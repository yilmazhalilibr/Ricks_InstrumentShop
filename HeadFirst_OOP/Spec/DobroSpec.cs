using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP.Spec
{
    public class DobroSpec : InstrumentSpec
    {
        public DobroSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
        }
    }
}
