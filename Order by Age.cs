using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ID> id = new List<ID>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] currInformation = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = currInformation[0];
                int age = int.Parse(currInformation[2]);
                int currId = int.Parse(currInformation[1]);
                foreach (var curInfo in id)
                {
                    if(currId == curInfo.Id)
                    {
                        curInfo.Age = age;
                        curInfo.Name = name;
                        continue;
                    }
                }
                ID information = new ID(name, currId, age);
                id.Add(information);
            }

            foreach (var printInfo in id.OrderBy(x => x.Age))
            {
                Console.WriteLine(printInfo);   
            }
        }
    }

    class ID
    {
        public ID(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
