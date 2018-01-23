using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;
            Console.WriteLine("Welcome to my program Odd and even Number");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            bool continue_run = true;
            while (continue_run)
            {
                Console.WriteLine();
                Console.Write("Enter a number between 1 and 100 : ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (number >= 1 && number <= 100)
                {
                    if (number % 2 == 1 && number<=60)
                    {
                        Console.WriteLine("The number you entered is odd");
                    }

                    else 
                    if (number % 2 == 1 && number > 60)
                    {
                        Console.WriteLine("The number you entered is Odd");
                    }
                    else
                    if (number % 2 == 0)
                    {
                        if (number >= 2 && number <= 25)
                        {
                            Console.WriteLine("The number is even and less than 25");
                        }
                        else
                        if (number >= 26 && number <= 60)
                        {
                            Console.WriteLine("The number entered is even");
                        }
                        else
                    if (number > 60)
                        {
                            Console.WriteLine("The number entered is Even");
                        }
                    }
                    
            }
            else
            {
                Console.WriteLine("hey " + name + " Your entered a number out range 1-100");
             //   Console.ReadKey();

            }

            Console.Write("continue(Y/N) : ");
            continue_run = Console.ReadKey().Key == ConsoleKey.Y;
        }
            //end while loop
            Console.WriteLine();
            Console.WriteLine("Thank you for using my program, Bye !");
          Console.ReadKey();

        }
    }
}
