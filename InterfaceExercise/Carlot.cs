using System;

namespace InterfaceExercise;

public class Carlot :IVehicle, ICompany 
{
    public string Type { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberofCupholders { get; set; }
    public int Price { get; set; }


    public string Name { get; set; }
    public int YearFounded { get; set; }
    
    public void DisplayDetails()
    {
        throw new System.NotImplementedException();
    }
    //creating a method to reuse and display details of each vehicle choice
    /*public void UseCarClass()
    {
        Car instanceOfCar = new Car();
        Console.WriteLine($"This is a {Year} {Name} {Model}.");
    }*/
    
    /*public void DisplayOption()
    {
        Console.WriteLine($"This is a {Year} {Name} {Model}.");
    }*/

    public void VehicleDetails()
    {
        Console.WriteLine("Choose any of these wonderful vehicles to see more details.");
        string answer = Console.ReadLine();
        string realAnswer = answer.ToLower();
        if (realAnswer == "ford focus" || realAnswer == "focus")
        {
            Console.WriteLine($"This is a {Car.focus.Year} {Car.focus.Name} {Car.focus.Model}.\nIt has {Car.focus.HowManyDoors} doors, {Car.focus.NumberofCupholders} cupholders and a sunroof.");
            Console.WriteLine($"The Price is ${Car.focus.Price}.");
        }
        else if (realAnswer == "ford mustang" || realAnswer == "mustang")
        {
           Console.WriteLine($"This is a {Car.mustang.Year} {Car.mustang.Name} {Car.mustang.Model}.\nIt has {Car.mustang.HowManyDoors} doors {Car.mustang.NumberofCupholders} cupholders and a sunroof."); 
           Console.WriteLine($"The Price is ${Car.mustang.Price}.");
        }
        else if (realAnswer == "ford f150" || realAnswer == "f150")
        {
            Console.WriteLine($"This is a {Truck.F150.Year} {Truck.F150.Name} {Truck.F150.Model}.\nIt is a Four Wheel Drive, {Truck.F150.TypeofCab}, with {Truck.F150.NumberofCupholders} cupholders.");
            Console.WriteLine($"The Price is ${Truck.F150.Price}.");
        }
        else if (realAnswer == "ford raptor" || realAnswer == "raptor")
        {
            Console.WriteLine($"This is a {Truck.raptor.Year} {Truck.raptor.Name} {Truck.raptor.Model}.\nIt is a Four Wheel Drive, {Truck.raptor.TypeofCab}, with {Truck.raptor.NumberofCupholders} cupholders.");
            Console.WriteLine($"The Price is ${Truck.raptor.Price}.");
        }
        else if (realAnswer == "lincoln navigator" || realAnswer == "navigator")
        {
            Console.WriteLine($"This is a {SUV.navigator.Year} {SUV.navigator.Name} {SUV.navigator.Model}.\nIt seats {SUV.navigator.HowManySeats} and does have heated seats.");
            Console.WriteLine($"The Price is ${SUV.navigator.Price}.");
        }
        else if (realAnswer == "ford escape" || realAnswer == "escape")
        {
            Console.WriteLine($"This is a {SUV.escape.Year} {SUV.escape.Name} {SUV.escape.Model}.\nIt seats {SUV.escape.HowManySeats} and does not have heated seats.");
            Console.WriteLine($"The Price is ${SUV.escape.Price}.");
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that on the lot. Please come back soon.");
        }
        
    }
}