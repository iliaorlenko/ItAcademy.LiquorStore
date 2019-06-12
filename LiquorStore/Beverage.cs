using System;
using System.Collections.Generic;
using System.Linq;

namespace LiquorStore
{
    public class Beverage
    {
        // Constructor with default parameters values
        public Beverage(
            string title = "Title unknown",
            string manufacturer = "Manufacturer unknown",
            AlcoholContent alcoholContentClass = AlcoholContent.None,
            List<KeyValuePair<Packaging, double?>> packAndVolume = null
            )
        {
            Title = title;
            Manufacturer = manufacturer;
            alcoholContentClass = AlcoholContentClass;
            PackAndVolume = packAndVolume;
            BeverageId++;
        }

        // Variables to represent beverage data
        public int BeverageId;
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public AlcoholContent AlcoholContentClass { get; set; }
        public List<KeyValuePair<Packaging, double?>> PackAndVolume { get; set; } // Nullable volume variable to maintain Tap packaging


        #region Methods
        // Method to display beverage basic information
        public virtual void ShowInfo()
        {
            Console.WriteLine("{0} {1} basic information:\n", Title, GetType().Name);
            Console.WriteLine("Beverage ID: {0}", BeverageId.ToString());
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Alcohol Content Class: {0}", AlcoholContentClass);
            ShowAllPackagingInfo(PackAndVolume);
        }

        // Method to go through all packaging variations and display them
        private void ShowAllPackagingInfo(List<KeyValuePair<Packaging, double?>> PackAndVolume)
        {
            Console.WriteLine("\nPackaging:");

            // Check if PackAndVolume dictionary is null
            if (PackAndVolume == null)
            {
                // Display info line and exit the method
                Console.WriteLine("No packaging information\n");
                return;
            }

            // If PackAndVolume is not null:
            // Variable to make numbered list
            int i = 1;

            // Go through each pair in PackAndVolume dictionary and display it as a separate row
            foreach (KeyValuePair<Packaging, double?> unit in PackAndVolume)
            {
                if (unit.Value != null)
                    Console.WriteLine(i++ + ". {0} - {1}", unit.Key, unit.Value);
                else
                    Console.WriteLine(i++ + ". {0}", unit.Key);
            }
            Console.WriteLine();
        }
        #endregion

        #region Overloaded Operators
        //Overloaded comparison operators are implemented to check larger variety of packaging of two beverages
        public static bool operator <(Beverage firstBeverage, Beverage secondBeverage)
        {
            if (firstBeverage.PackAndVolume.Count < secondBeverage.PackAndVolume.Count)
                return true;
            else
                return false;
        }

        public static bool operator >(Beverage firstBeverage, Beverage secondBeverage)
        {
            if (firstBeverage.PackAndVolume.Count > secondBeverage.PackAndVolume.Count)
                return true;
            else
                return false;
        }
        public static bool operator <=(Beverage firstBeverage, Beverage secondBeverage)
        {
            if (firstBeverage.PackAndVolume.Count <= secondBeverage.PackAndVolume.Count)
                return true;
            else
                return false;
        }

        public static bool operator >=(Beverage firstBeverage, Beverage secondBeverage)
        {
            if (firstBeverage.PackAndVolume.Count >= secondBeverage.PackAndVolume.Count)
                return true;
            else
                return false;
        }
        #endregion
    }

    public enum Packaging
    {
        None,
        Glass,
        Box,
        Can,
        Plastic,
        Tap
    }

    public enum AlcoholContent
    {
        None,
        Strong,
        MidAlcoholic,
        LowAlcoholic,
        NonAlcoholic
    }
}
