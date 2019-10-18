using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            string sex;
            Console.WriteLine("Are you coming or leaving?");
            userAnswer = Console.ReadLine();
            Console.WriteLine("What is your gender?");
            sex = Console.ReadLine();

            if(userAnswer.ToLower() == "coming")
            {
                Hello(sex);
            }
            else if(userAnswer.ToLower() == "leaving")
            {
                Goodbye();
            }
            else
            {
                Console.WriteLine("Don't be rude!");
            }

            Console.ReadLine();
        }

        public static void Hello(string sex)
        {
            if(sex == "male")
            {
                Console.WriteLine("Hello, Sir!");
            }
            else if(sex == "female")
            {
                Console.WriteLine("Hello, Madam!");
            }
            else
            {
                Console.WriteLine("Sorry, can't identify you.");
            }
           
            
        }

        public static void Goodbye()
        {

            Console.WriteLine("Goodbye!");

        }

    }
}
