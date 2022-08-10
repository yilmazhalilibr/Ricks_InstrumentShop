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
            GuitarSpec whatErinLikesSpec = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 1, Wood.ALDER, Wood.ALDER);
            Inventory inventory = new Inventory();
            initializeInventory(inventory);
            Guitar whatErinLikes = new Guitar(
                "",
                0, whatErinLikesSpec);

            var guitarList = inventory.Search(whatErinLikesSpec);
            if (guitarList.Count > 0)
            {

                foreach (var guitar in guitarList)
                {
                    Console.WriteLine($"{guitar.GetInstrumentSpec().GetBuilder()} " +
                        $"{guitar.GetInstrumentSpec().GetModel()} {guitar.GetInstrumentSpec().GetType()} " +
                        $"{guitar.GetInstrumentSpec().GetBackWood()} {guitar.GetInstrumentSpec().GetTopWood()} {guitar.GetPrice()}"
                  );
                }


            }
            else
            {
                Console.WriteLine("Sorry not found.");

            }
            Console.ReadLine();
        }
        private static void initializeInventory(Inventory inventory)
        {
            GuitarSpec GuitarStratocastor = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 1, Wood.ALDER, Wood.ALDER);
            GuitarSpec GuitarStratocastor2 = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 2, Wood.ALDER, Wood.ALDER);
            inventory.addInstrument("V9505", 1549.55, GuitarStratocastor);
            inventory.addInstrument("V9504", 1249.55, GuitarStratocastor2);
        }
    }

}
