using System;
using System.Collections.Generic;
using System.Text;
namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            ReadingVehicles(ref vehicles);
            PrintingVehicles(ref vehicles);
            HorsePowerCalculator(ref vehicles);
        }
        
        private static List<Vehicles> ReadingVehicles(ref List<Vehicles> vehicles)
        {
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split();

                Vehicles currentVehicle = new Vehicles
                {
                    TypeOfVehicle = data[0],
                    Model = data[1],
                    Color = data[2],
                    HorsePower = int.Parse(data[3])
                };
                vehicles.Add(currentVehicle);
            }
            return vehicles;
        }
        
        private static void PrintingVehicles(ref List<Vehicles> vehicles)
        {
            string command;
            while((command = Console.ReadLine()) != "Close the Catalogue")
            {
                string currentVehicle = command;
                foreach (var vehicle in vehicles)
                {
                    if(vehicle.Model == currentVehicle)
                    {
                        Console.WriteLine(vehicle.ToString());
                    }
                }
            }
        }

        private static void HorsePowerCalculator(ref List<Vehicles> vehicles)
        {
            double totalTrucks = 0;
            double totalCars = 0;
            double totalTruckHP = 0;
            double totalCarHP = 0;

            foreach (var currVehicle in vehicles)
            {
                if(currVehicle.TypeOfVehicle == "truck")
                {
                    totalTrucks++;
                    totalTruckHP += currVehicle.HorsePower;
                }
                else if(currVehicle.TypeOfVehicle == "car")
                {
                    totalCars++;
                    totalCarHP += currVehicle.HorsePower;
                }
            }
            double averageCarHP = totalCarHP / totalCars;
            double averageTruckHP = totalTruckHP / totalTrucks;
            if(totalCars == 0)
            {
                averageCarHP = 0;
            }
            if(totalTrucks == 0)
            {
                averageTruckHP = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:F2}.");
        }

    }
        class Vehicles
        {
            public string TypeOfVehicle { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Type: {char.ToUpper(TypeOfVehicle[0]) + TypeOfVehicle.Substring(1)}");
            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Color: {Color}");
            stringBuilder.AppendLine($"Horsepower: {HorsePower}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
