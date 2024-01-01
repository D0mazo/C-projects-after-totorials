using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program");

            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("a for addition, s for substraction, m for multiplication, d for division. If you will enter some kind of nonsence program will divide the numbers");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }

            else if(answer == "s")
            {
                result = num1 - num2;
            }

            else if(answer == "m")
            {
                result = num1 * num2;
            }

            else
            {
                result = num1/num2;
            }
            System.Console.WriteLine("The result is" + "" + result);
            System.Console.WriteLine("Thx for using my calculator program");
            Console.ReadKey();
        }
    }

}