using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What shape area do you want to calculate? Press 'r' for rectangle, any other key for circle:");

            string answer = Console.ReadLine();
            float result = 0;

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of rectangle:");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of rectangle:");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else
            {
                Console.WriteLine("Please enter the radius of circle:");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}