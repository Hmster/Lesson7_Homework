using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = "password";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == pass)
            {
                Console.WriteLine("Welcome!");
            }

            Console.ReadKey(true);
        }
    }
}
