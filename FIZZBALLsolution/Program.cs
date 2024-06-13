namespace FIZZBALLsolution;
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;


            for (var nbr = 1; nbr <= 30; nbr++)
            {
                if (nbr % 3 == 0 && nbr % 5 == 0)
                {
                    System.Console.WriteLine($"{nbr}:FIZZBUZZ");
                }
                else if (nbr % 3 == 0 && nbr % 5 != 0)
                {
                    System.Console.WriteLine($"{nbr}:FIZZ ");
                }

                else if (nbr % 3 != 0 && nbr % 5 == 0)
                {
                    System.Console.WriteLine($"{nbr}:BUZZ ");
                }

                else
                    Console.WriteLine($"{nbr}");

            }

        }
    }

