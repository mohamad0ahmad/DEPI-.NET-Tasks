using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7): ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 7)
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());
                Console.WriteLine($"Day: {day}");
            }
            else
            {
                Console.WriteLine("Invalid number! Please enter between 1 and 7.");
            }

            // What happens if the user enters a value outside the range of 1 to 7? 
            //The Enum.Parse will still convert it into an enum type,
            //but it will produce a value that doesn’t exist in the defined enum list.
            //That’s why we check the range before parsing to avoid showing meaningless values.

        }
    }
}
