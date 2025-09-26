using System;
using System.Collections.Generic;

namespace InterfaceExercise;

public class SUV: IVehicle, ICompany
{
    
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */


    public bool HeatedSeats { get; set; } = false;
    public int HowManySeats { get; set; } = 8;


    public string Type { get; set; } = "Large SUV";
    public string Model { get; set; } = "Navigator";
    public int Year { get; set; } = 2024;
    public int NumberofCupholders { get; set; } = 10;
    public int Price { get; set; }



    public string Name { get; set; } = "Lincoln";
    public int YearFounded { get; set; } = 1917;

    public static SUV navigator = new SUV()
    {
        Type = "Large SUV",
        Model = "Navigator",
        Year = 2024,
        NumberofCupholders = 10,
        HeatedSeats = true,
        HowManySeats = 8,
        Name = "Lincoln",
        YearFounded = 1917,
        Price = 85000
    };

    public static SUV escape = new SUV()
    {
        Type = "Medium SUV",
        Model = "Escape",
        Year = 2020,
        NumberofCupholders = 6,
        HeatedSeats = false,
        HowManySeats = 5,
        Name = "Ford",
        YearFounded = 1903,
        Price = 21984,
    };
    
    public void DisplayDetails()
    {
        var suvs = new List<SUV>();
        suvs.Add(navigator);
        suvs.Add(escape);
        foreach (var suv in suvs)
        {
            Console.WriteLine($"{suv.Year} {suv.Name} {suv.Model}");
        }

    }
   
}