using System;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] currCar = command.Split();

                string typeOfVehicle = currCar[0];
                string model = currCar[1];
                string color = currCar[2];
                int horsePower = int.Parse(currCar[3]);

                Cars car = new Cars(typeOfVehicle, model, color, horsePower);
                cars.Add(car);
            }
            double totalCarsHorsePower = 0;
            double totalTrucksHorsePower = 0;
            int totalCars = 0;
            int totalTrucks = 0;
            string secondCommand;
            while((secondCommand = Console.ReadLine()) != "Close the Catalogue")
            {
                string requestedCar = secondCommand;
                foreach (var car in cars)
                {
                    if(car.Model == requestedCar)
                    {
                        if(car.TypeOfVehicle == "truck")
                        {
                            Console.WriteLine("Type: Truck");
                        }   
                        else if(car.TypeOfVehicle == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }      
                    
                }
            }
            foreach (var car in cars)
            {
                if (car.TypeOfVehicle == "car")
                {
                    totalCarsHorsePower += car.HorsePower;
                    totalCars++;
                }
                else if (car.TypeOfVehicle == "truck")
                {
                    totalTrucksHorsePower += car.HorsePower;
                    totalTrucks++;
                }
            }
            double averageCarsHorsePower = totalCarsHorsePower / totalCars;
            double averageTrucksHorsePower = totalTrucksHorsePower / totalTrucks;
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsePower:F2}.");
        }
    }

    class Cars
    {
        public Cars(string typeOfVehicle, string model, string color, int horsePower)
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        

        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }
}
