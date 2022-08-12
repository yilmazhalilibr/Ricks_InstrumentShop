using HeadFirst_OOP.EnumType;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory();
            initializeInventory(inventory);


            Dictionary<string, object> propertiesList = new Dictionary<string, object>();

            propertiesList.Add("builder", Builder.GIBSON);
            //propertiesList.Add("backWood", Wood.MAPLE);
            //propertiesList.Add("topWood", Wood.COCOBOLO);


            InstrumentSpec clientSpec = new InstrumentSpec(propertiesList);
            try
            {
                var matchingInstruments = inventory.Search(clientSpec);
                if (matchingInstruments.Count != 0 && matchingInstruments != null)
                {
                    Console.WriteLine("You might like these instruments:");
                    for (int i = 0; i < 1; i++)
                    {
                        Instrument instrument = matchingInstruments[i];
                        InstrumentSpec spec = instrument.GetInstrumentSpec();


                        if (!(spec.GetProperties().ContainsKey("instrumentType")))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("We have a " + spec.GetProperty("instrumentType") + " with the following properties:");
                            int count = 1;
                            foreach (var j in instrument.GetInstrumentSpec().GetProperties())
                            {
                                Console.WriteLine();
                                Console.Write(count + " - " + j.Key);
                                Console.Write(" : ");
                                Console.Write(j.Value);
                                count++;
                            }


                        }
                        Console.WriteLine("\n" + "----You can have this " + spec.GetProperty("instrumentType") + " for $" + instrument.GetPrice() + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, we have nothing for you.");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Error: Main Exception");

            }





            Console.ReadLine();
        }
        private static void initializeInventory(Inventory inventory)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("instrumentType", InstrumentType.GUITAR);
            properties.Add("builder", Builder.GIBSON);
            properties.Add("model", "CJ");
            properties.Add("type", Type.ACOUSTIC);
            properties.Add("numString", 6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Wood.MAPLE);
            inventory.addInstrument("11277", 3999.95, new InstrumentSpec(properties));
        }
    }

}
