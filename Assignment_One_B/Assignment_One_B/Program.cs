using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One_B
{
    class Program
    {
        //Main method begins the execution of a c# app
        static void Main(string[] args)
        {
            float number1; // declare variable for first number
            float number2; // declare variable for second number
            float sum; // declare variable to store the sum
            float subtraction;
            float division;
            float multiplication;
            float quotient;

            Console.WriteLine("Enter First Number"); // prompt user
            number1 = float.Parse(Console.ReadLine()); // read the entered characters and convert it to a float
            Console.WriteLine("Enter Second Number");
            number2 = float.Parse(Console.ReadLine());

            sum = number1 + number2; // add numbers
            subtraction = number1 - number2;
            division = number1 / number2; 
            multiplication = number1 * number2;
            quotient = number1 % number2;

            // Display results
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Subtraction is {subtraction}");
            Console.WriteLine($"Division is {division}");
            Console.WriteLine($"Mulplication is {multiplication}");
            Console.WriteLine($"Quotient is {quotient}");
            Console.Read(); // added this so that console can stay open to see the results

        }
    }
}
