using System;
using System.Collections.Generic;

namespace InterfaceExercise;

public class Car :IVehicle, ICompany
{
    
    //In each of your Car, Truck, and SUV classes

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */


    public int HowManyDoors { get; set; } = 4;
    public bool Sunroof { get; set; } = true;


    public string Type { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberofCupholders { get; set; }
    
    public int Price { get; set; } 


    public string Name { get; set; } = "Ford";
    public int YearFounded { get; set; } = 1903;

    public static Car focus = new Car()
    {
        Type = "Sedan",
        Model = "Focus",
        Year = 2018,
        HowManyDoors = 4,
        Sunroof = true,
        NumberofCupholders = 5,
        Name = "Ford",
        YearFounded = 1903,
        Price = 10699,
    };

    public static Car mustang = new Car()
    {
        Type = "Two Door",
        Model = "Mustang",
        Year = 2024,
        HowManyDoors = 2,
        Sunroof = true,
        NumberofCupholders = 4,
        Name = "Ford",
        YearFounded = 1903,
        Price = 23984, 
    };
    
    
    public void DisplayDetails()
    {
        var cars = new List<Car>();
        cars.Add(focus);
        cars.Add(mustang);
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Year} {car.Name} {car.Model}");
        }
        
    }
    
    

}