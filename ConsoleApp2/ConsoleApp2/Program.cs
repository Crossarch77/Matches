using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Run();
            } while (Console.ReadKey(true).Key != ConsoleKey.E);
        }

        static double Switch (double s)
        {
            double n = 0;
            switch (s)
            {
                case 0:
                    Console.WriteLine("Are you sure about 0? It's just 0. Press Enter to try again...");
                    Console.ReadLine();
                    Calc();
                    break;
                case 1:
                    n = s * 4;
                    return n;
                default:
                    if ((s % 2 == 0) && (s > 1))
                    {
                        n = 2 + s * 5 / 2;
                        return n;
                    }
                    else if ((s % 2 == 1) && (s > 1))
                    {
                        n = (s+1) * 5 / 2;
                        return n;
                    }
                    else if (s < 0)
                    {
                        Console.WriteLine("Nice joke btw... Try again, just press Enter to continue.");
                        Console.ReadLine();
                        Calc();
                    }
                    break;
            }
            return n;
        }

        static void Calc()
        {
            Console.Clear();
            double n = 0;
            Console.Write("Enter the number of squares: ");
            double s = double.Parse(Console.ReadLine());
            n = Switch(s);
            Console.WriteLine("The minimum number of matches required is: " + n);
            Console.WriteLine("Press E to exit or any key to try again.");
            
        }

        static void Run()
        {
            try
            {
                Calc();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the number! Press Enter to try again.");
                Console.ReadLine();
                Run();
            }
        }
    }
}
