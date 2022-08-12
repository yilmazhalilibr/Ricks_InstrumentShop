using System;
using System.Collections.Generic;

namespace HeadFirst_OOP
{
    public class InstrumentSpec
    {
        private Dictionary<string, object> _properties;

        public InstrumentSpec(Dictionary<string, object> properties)
        {
            if (properties == null)
            {
                _properties = new Dictionary<string, object>();
            }
            else
            {
                _properties = new Dictionary<string, object>(properties);
            }
        }
        public object GetProperty(string propertyName)
        {
            return _properties.ContainsKey(propertyName) ? _properties[propertyName] : null;
        }
        public Dictionary<string, object> GetProperties()
        {
            return _properties;
        }

        public bool matches(InstrumentSpec otherSpec)
        {
            /*
            var spec = otherSpec.GetProperties();
            foreach (var i in spec)
            {
                foreach (var j in _properties)
                {
                    if (!(i.Key == j.Key) && !(i.Value == j.Value))
                    {
                        if (_properties.Keys.Count > 7 )
                        {
                            
                        }
                        
                    }
                }

            }
            */





            foreach (var i in otherSpec.GetProperties())
            {

                if (_properties.ContainsValue(i.Value))
                {
                    return true;
                }
            }
            return false;
        }







        /*
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
         */
    }
}