using System;
using System.Collections.Generic;

namespace InterfaceExercise;

public class Truck: IVehicle, ICompany
{
    
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */


    public string TypeofCab { get; set; }
    public bool FourWheelDrives { get; set; }


    public string Type { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberofCupholders { get; set; }
    public int Price { get; set; }



    public string Name { get; set; } = "Ford";
    public int YearFounded { get; set; } = 1903;

    public static Truck F150 = new Truck()
    {
        Type = "Truck",
        Model = "F150",
        Year = 2023,
        NumberofCupholders = 6,
        Name = "Ford",
        YearFounded = 1903,
        TypeofCab = "Crew Cab",
        FourWheelDrives = true,
        Price = 30395
    };

    public static Truck raptor = new Truck()
    {
        Type = "Truck",
        Model = "Raptor",
        Year = 2024,
        NumberofCupholders = 6,
        Name = "Ford",
        YearFounded = 1903,
        TypeofCab = "Crew Cab",
        FourWheelDrives = true,
        Price = 81965,

    };
    
    public void DisplayDetails()
    {
        var trucks = new List <Truck>();
        trucks.Add(F150);
        trucks.Add(raptor);
        foreach (var truck in trucks)
        {
            Console.WriteLine($"{truck.Year} {truck.Name} {truck.Model}");
        }

    }
} 