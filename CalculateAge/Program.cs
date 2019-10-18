using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth;
            Console.WriteLine("Enter your year of birth: ");
            yearOfBirth = int.Parse(Console.ReadLine());
            CalculateAge(yearOfBirth);

            Console.ReadLine();
        }

        public static void CalculateAge(int yearOfBirth)
        {
            Console.WriteLine($"You are {2019 - yearOfBirth}");
        }
    }
}
