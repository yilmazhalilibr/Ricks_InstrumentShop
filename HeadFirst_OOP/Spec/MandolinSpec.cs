namespace HeadFirst_OOP
{
    public class MandolinSpec : InstrumentSpec
    {
        private Style _style;

        public MandolinSpec(Builder builder, string model, Type type, Style style, Wood backWood, Wood topWood) : base(builder, model, type, backWood, topWood)
        {
            _style = style;
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
            if (!typeof(MandolinSpec).IsInstanceOfType(otherSpec))
            {
                return false;
            }
            MandolinSpec spec = (MandolinSpec)otherSpec;
            if (!_style.Equals(spec._style))
            {
                return false;
            }

            return true;



        }



    }
}