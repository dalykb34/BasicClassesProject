using System;

namespace BasicClassesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car();
            firstCar.Make = "Chevy";
            firstCar.Model = "Colorado";
            firstCar.Year = 2018;


            Console.WriteLine($"My car is a {firstCar.Year} {firstCar.Make} {firstCar.Model}!");


            var yourCar = new Car();
            Console.WriteLine($"What make is your vehicle?");
            yourCar.Make = Console.ReadLine();
            Console.WriteLine($"What model is your vehicle?");
            yourCar.Model = Console.ReadLine();
            Console.WriteLine($"What year was your vehicle made?");
            yourCar.Year =  Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine($"Your car is a {yourCar.Year} {yourCar.Make} {yourCar.Model}!");
        }
    }
}
