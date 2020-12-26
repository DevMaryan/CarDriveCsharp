using System;
using CarDrive.Models;

namespace CarDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // We create new Object
            var car1 = new Car("BMW", 360);
            var car2 = new Car("Mercedes", 340);
            var car3 = new Car("Ferrari", 370);
            var car4 = new Car("Bugati", 350);

            // We are adding the objects into array
            var cars = new Car[] { car1, car2, car3, car4 };

            // We create new Object
            var driver1 = new Driver("John", 4);
            var driver2 = new Driver("Doe", 6);
            var driver3 = new Driver("Marjan", 7);
            var driver4 = new Driver("Peter", 5);

            // We are adding the objects into array
            var drivers = new Driver[] { driver1, driver2, driver3, driver4 };

            // Short Version of the Game 
            //car1.Driver = driver1;
            //car2.Driver = driver2;
            //RaceCars(car1, car2);

            // Other Version

            var continueGame = true;

            do
            {
                var firstCar = ChooseCar(cars);
                var secondCar = ChooseCar(cars);

                var firstDriver = ChooseDriver(drivers);
                var secondDriver = ChooseDriver(drivers);

                firstCar.Driver = firstDriver;
                secondCar.Driver = secondDriver;

                RaceCars(firstCar, secondCar);
                Console.WriteLine($"Enter \'n\' to Exit or Press any key to continue...");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "n")
                {
                    continueGame = false;
                }
            } while (continueGame);
        }
        public static void RaceCars(Car car1, Car car2)
        {
            if(car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine($"The winner is {car1.Driver.Name} who has {car1.Model} car. Score: {car1.CalculateSpeed()}");
                Console.WriteLine($"Driver Skill {car1.Driver.Skill}");
                Console.WriteLine($"Car Speed {car1.Speed}");
                Console.WriteLine($"The loser is {car2.Driver.Name} who has {car2.Model} car. Score: {car2.CalculateSpeed()} ");
            }
            else
            {
                Console.WriteLine($"The winner is {car2.Driver.Name} who has {car2.Model} car.");
                Console.WriteLine($"Driver Skill {car2.Driver.Skill}");
                Console.WriteLine($"Driver Skill {car2.Speed}");
            }
        }
        public static Car ChooseCar(Car[] cars)
        {
            Console.WriteLine("Choose car by choosing number");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i}. {cars[i].Model}");
            }

            var carInput = int.Parse(Console.ReadLine());
            var car = cars[carInput];

            return car;
        }
        public static Driver ChooseDriver(Driver[] drivers)
        {
            Console.WriteLine("Choose car by choosing number");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i}. {drivers[i].Name}");
            }

            var driverInput = int.Parse(Console.ReadLine());
            var driver = drivers[driverInput];

            return driver;
        }
    }
}
