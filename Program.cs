namespace Dr.LeeFinalQ4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Please enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
                numbers.Add(number);
            }

            int min = numbers.Min();
            int max = numbers.Max();
            double average = numbers.Average();

            Console.WriteLine($"\nMinimum: {min}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Average: {average:F2}");
        }
    }

}
