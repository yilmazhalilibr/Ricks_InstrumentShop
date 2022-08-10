using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public abstract class Instrument
    {

        protected string _serialNumber;
        protected double _price;
        protected InstrumentSpec _spec;



        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }

        public string GetSerialNumber()
        {
            return _serialNumber;
        }
        public double GetPrice()
        {
            return _price;
        }
        public void SetPrice(double price)
        {
            _price = price;
        }
        public InstrumentSpec GetInstrumentSpec()
        {
            return _spec;
        }
        public bool matches(InstrumentSpec otherSpec)
        {


            return true;


        }







    }
}
