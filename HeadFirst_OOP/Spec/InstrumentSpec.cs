namespace HeadFirst_OOP
{
    public abstract class InstrumentSpec
    {
        private Builder _builder;
        private string _model;
        private Type _type;
        private Wood _backWood;
        private Wood _topWood;



        public InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;

        }

        public Builder GetBuilder()
        {
            return _builder;
        }

        public string GetModel()
        {
            return _model;
        }

        public Type GetType()
        {
            return _type;
        }

        public Wood GetBackWood()
        {
            return _backWood;
        }
        public Wood GetTopWood()
        {
            return _topWood;
        }




        public bool matches(InstrumentSpec otherSpec)
        {
            if (_builder != otherSpec._builder)
            {
                return false;
            }
            if ((_model != null) && (!_model.Equals("")) && (!_model.Equals(otherSpec._model)))
            {
                return false;
            }
            if (_type != otherSpec._type)
            {
                return false;
            }
            if (_backWood != otherSpec._backWood)
            {
                return false;
            }
            if (_topWood != otherSpec._topWood)
            {
                return false;
            }


            return true;

        }

    }
}