

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    public class Inventory
    {
        private List<Instrument> instrumentList;
        public Inventory()
        {
            instrumentList = new List<Instrument>();
        }

        public void addInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);
            instrumentList.Add(instrument);
        }
        public Instrument GetInstrument(string serialNumber)
        {
            foreach (var instrument in instrumentList)
            {

                if (instrument.GetSerialNumber().Equals(serialNumber))
                {
                    return instrument;
                }

            }
            return null;
        }

        /*
        //-------------------------------------------------
        //-------------------------------------------------
        //-------------------------------------------------
        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            Builder builder = searchSpec.GetBuilder();
            string model = searchSpec.GetModel().ToString();
            Type type = searchSpec.GetType();
            Wood backWood = searchSpec.GetBackWood();
            Wood topWood = searchSpec.GetTopWood();
            var matchingGuitars = new List<Guitar>();

            for (var i = 0; i < instrumentList.Count; i++)
            {

                var guitarSpec = instrumentList[i].GetInstrumentSpec();
                if (builder == Builder.UNDEFINED || builder != guitarSpec.GetBuilder())
                {
                    continue;
                }
                if (model == null || model == "" || model.ToLower() != guitarSpec.GetModel().ToLower())
                {

                    continue;
                }
                if (type == Type.UNDEFINED || type != guitarSpec.GetType())
                {

                    continue;
                }
                if (backWood == Wood.UNDEFINED || backWood != guitarSpec.GetBackWood())
                {

                    continue;
                }
                if (topWood == Wood.UNDEFINED || topWood != guitarSpec.GetTopWood())
                {

                    continue;
                }
                if (guitarSpec.matches(searchSpec))
                {
                    matchingGuitars.Add((Guitar)instrumentList[i]);
                }

            }

            return matchingGuitars;


        }

        public List<Mandolin> Search(MandolinSpec searchSpec)
        {
            var mandolinList = new List<Mandolin>();
            for (int i = 0; i < instrumentList.Count; i++)
            {
                var mandolinSpec = instrumentList[i].GetInstrumentSpec();
                if (mandolinSpec.matches(searchSpec))
                {
                    mandolinList.Add((Mandolin)instrumentList[i]);
                }
            }
            return mandolinList;
        }

        public List<Banjo> Search(BanjoSpec searchSpec)
        {
            Builder builder = searchSpec.GetBuilder();
            string model = searchSpec.GetModel().ToString();
            Type type = searchSpec.GetType();
            Wood backWood = searchSpec.GetBackWood();
            Wood topWood = searchSpec.GetTopWood();
            var matchingGuitars = new List<Banjo>();

            for (var i = 0; i < instrumentList.Count; i++)
            {

                var guitarSpec = instrumentList[i].GetInstrumentSpec();
                if (builder == Builder.UNDEFINED || builder != guitarSpec.GetBuilder())
                {
                    continue;
                }
                if (model == null || model == "" || model.ToLower() != guitarSpec.GetModel().ToLower())
                {

                    continue;
                }
                if (type == Type.UNDEFINED || type != guitarSpec.GetType())
                {

                    continue;
                }
                if (backWood == Wood.UNDEFINED || backWood != guitarSpec.GetBackWood())
                {

                    continue;
                }
                if (topWood == Wood.UNDEFINED || topWood != guitarSpec.GetTopWood())
                {

                    continue;
                }
                if (guitarSpec.matches(searchSpec))
                {
                    matchingGuitars.Add((Banjo)instrumentList[i]);
                }

            }

            return matchingGuitars;


        }
        //-------------------------------------------------
        //-------------------------------------------------
        //-------------------------------------------------
        */
        public List<Instrument> Search(InstrumentSpec searchSpec)
        {
            List<Instrument> newList = new List<Instrument>();
            for (int i = 0; i < 1; i++)
            {
                Instrument instrument = instrumentList[instrumentList.Count - 1 + i];
                if (instrument.GetInstrumentSpec().matches(searchSpec))
                {
                    newList.Add(instrument);

                }
            }

            return newList;
        }
    }
}
