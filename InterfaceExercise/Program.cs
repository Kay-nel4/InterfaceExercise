using System;
using System.Threading;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            Console.WriteLine(
                "Welcome to the C# virtual Dealership, Where we would like to \"C You in a # Vehicle\"\nPlease take a look at our options.");
            Thread.Sleep(4000);
            Console.Clear();
            Car helloMessage = new Car();
            helloMessage.DisplayDetails();
            Truck helloMessage2 = new Truck();
            helloMessage2.DisplayDetails();
            SUV helloMessage3 = new SUV();
            helloMessage3.DisplayDetails();

            Carlot test = new Carlot();
            test.VehicleDetails();
            Thread.Sleep(4000);


            Console.WriteLine("Is this the car of your dreams?");
            var response = Console.ReadLine();
            while (response.ToLower() == "no")
            {
                Console.WriteLine("Would you like to see another option?");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    helloMessage.DisplayDetails();
                    helloMessage2.DisplayDetails();
                    helloMessage3.DisplayDetails();

                    test.VehicleDetails();
                }
                else if (answer.ToLower() == "no")
                {
                    Console.WriteLine("Thanks for visiting the Virtual C# Carlot, C you again Soon!");
                    Thread.Sleep(4000);
                    Console.Clear();
                    return;
                }
                
               
            }
            Console.WriteLine("Great let's get you into your new car!\nThanks for choosing the C# Virtual Dealership");        
            Thread.Sleep(4000); 
            Console.Clear();

        }
    } 
    //create a carlot in the display details method include a line that tells the basics of each car on the lot 2023 truck, 2022 suv
    // etc then create a switch statement and if else to handle the type of vehicle the user wants to see. Display that option and then
    //ask if they would like to see another vehicle or finish.
}
