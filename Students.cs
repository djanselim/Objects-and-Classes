using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> stutends = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] currStudent = Console.ReadLine().Split();
                string firstName = currStudent[0];
                string lastName = currStudent[1];
                float grade = float.Parse(currStudent[2]);
                Students currentStudents = new Students(firstName, lastName, grade);
                stutends.Add(currentStudents);
            }
            foreach (var currStudent in stutends.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(currStudent);
            }
        }
    }

    class Students
    {
        public Students(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
