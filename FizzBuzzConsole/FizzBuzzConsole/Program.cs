using System;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(1);
        }

        private static void FizzBuzz(int number)
        {
            int max = 100;

            while (number <= max)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                Console.WriteLine(number);
                number++;
            }
        }
    }
}
