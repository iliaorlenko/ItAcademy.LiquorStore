using System;
using System.Collections.Generic;

namespace LiquorStore
{
    public class Beer : Beverage
    {
        // Constructor with default parameters values and with reference to base class's constructor
        public Beer(
            string title = "Title unknown",
            string manufacturer = "Manufacturer unknown",
            AlcoholContent alcoholContentClass = AlcoholContent.None,
            List<KeyValuePair<Packaging, double?>> packAndVolume = null,
            BeerType Type = BeerType.None,
            FilteringType Filtering = FilteringType.None
            ) : base(title, manufacturer, alcoholContentClass, packAndVolume)
        {
            this.Type = Type;
            this.Filtering = Filtering;
            NumberOfBeers++;
        }

        // Variables to represent beverage data
        private static int NumberOfBeers;
        public BeerType Type { get; set; }
        public FilteringType Filtering { get; set; }
        
        // Override method to display specific information for beer object
        public override void ShowInfo()
        {
            // Call base class methdod for displaying basic information
            base.ShowInfo();
            Console.WriteLine("\n{0} specific information:\n", Title);
            Console.WriteLine("Beer Type: {0}", Type);
            Console.WriteLine("Filtering Type: {0}", Filtering);
        }

        public static void ShowNumberOfBeers()
        {
            Console.WriteLine("Total number of beverages: {0}", NumberOfBeers);
        }
    }

    public enum BeerType
    {
        None,
        Pilsner,
        Lager,
        Stout,
        Ale
    }

    public enum FilteringType
    {
        None,
        Filtered,
        Unfiltered
    }
}
