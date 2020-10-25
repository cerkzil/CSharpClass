using System;

namespace CSharpClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1-7 to get a weekday:");

            bool validInput = int.TryParse(Console.ReadLine(), out int number);
            if (validInput)
            {
                if (0 < number && number < 8)
                {
                    WeekDays day = (WeekDays)number;
                    Console.WriteLine("That's " + day);
                }
                else
                {
                    Console.WriteLine("Wrong number, should be (1-7)");
                }
            }
            else
            {
                Console.WriteLine("Not a number");
            }
        }
    }

    public enum WeekDays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
}


