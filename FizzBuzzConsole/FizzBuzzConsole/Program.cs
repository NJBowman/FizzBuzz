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
                string output = "";

                if (number % 3 == 0)
                {
                    output = output + "Fizz";
                }
                if (number % 5 == 0)
                {
                    output = output + "Buzz";
                }

                var result = output.Length > 0 ? output : number.ToString();

                Console.WriteLine(result);
                number++;
            }
        }
    }
}
