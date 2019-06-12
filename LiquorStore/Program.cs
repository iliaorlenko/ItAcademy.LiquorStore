using System;
using System.Collections.Generic;

namespace LiquorStore
{
    class Program
    {
        static void Main(string[] args)
        {

            // Start with creating empty object...
            Beer A10 = new Beer();
            // ...and then assign all the date to its variables as a separate code
            A10.Title = "A10";
            A10.Manufacturer = "Alivariya";
            A10.AlcoholContentClass = AlcoholContent.MidAlcoholic;
            A10.PackAndVolume = new List<KeyValuePair<Packaging, double?>>
            {
                new KeyValuePair<Packaging, double?>(Packaging.Can, 0.5),
                new KeyValuePair<Packaging, double?>(Packaging.Glass, 0.5),
                new KeyValuePair<Packaging, double?>(Packaging.Plastic, 1.0),
                new KeyValuePair<Packaging, double?>(Packaging.Plastic, 1.5),
                new KeyValuePair<Packaging, double?>(Packaging.Plastic, 2.0),
                new KeyValuePair<Packaging, double?>(Packaging.Tap, null)
            };
            A10.Type = BeerType.Pilsner;
            A10.Filtering = FilteringType.Filtered;

            // Create object specifying all its parameters in the constructor
            Beer Koronet = new Beer(
                "Koronet",
                "Lida Brewery",
                AlcoholContent.LowAlcoholic,
                new List<KeyValuePair<Packaging, double?>>
                {
                    new KeyValuePair<Packaging, double?>( Packaging.Can, 0.568 ),
                    new KeyValuePair<Packaging, double?>( Packaging.Glass, 0.568 ),
                    new KeyValuePair<Packaging, double?>( Packaging.Plastic, 1.136 ),
                    //new KeyValuePair<Packaging, double?>( Packaging.Tap, null )
                },
                BeerType.Pilsner,
                FilteringType.Filtered
                );

            // Create object with empty constructor but specify all its parameters in the object body
            Beer Guinness = new Beer()
            {
                Title = "Guinness",
                Manufacturer = "Diageo",
                AlcoholContentClass = AlcoholContent.MidAlcoholic,
                PackAndVolume = new List<KeyValuePair<Packaging, double?>>
                {
                    new KeyValuePair<Packaging, double?>(Packaging.Can, 0.5),
                    new KeyValuePair<Packaging, double?>(Packaging.Glass, 0.5),
                    new KeyValuePair<Packaging, double?>(Packaging.Tap, null)
                },
                Type = BeerType.Stout,
                Filtering = FilteringType.Filtered
            };

            // Show info of Beer object
            Guinness.ShowInfo();

            // Add a couple of other derived class's objects
            Vodka vodka = new Vodka();
            Vodka vodka2 = new Vodka();
            Console.WriteLine("\nA couple of Vodka beverages has been added");

            //Show total number of objects of Beverage type
            Beverage.ShowNumberOfBeverages();

            //Show total number of objects of Beer type
            Beer.ShowNumberOfBeers();
            Console.WriteLine();

            // Compare whether one beverage contains more packaging options than other
            Console.WriteLine("Guinness has less packaging types than Koronet: " + (Guinness < Koronet).ToString());
            Console.WriteLine("Guinness has more packaging types than Koronet: " + (Guinness > Koronet).ToString());
            Console.WriteLine("Guinness has less packaging types than Koronet or equal: " + (Guinness <= Koronet).ToString());
            Console.WriteLine("Guinness has more packaging types than Koronet or equal: " + (Guinness >= Koronet).ToString());

            // Make console wait
            Console.ReadKey();
        }
    }
}
