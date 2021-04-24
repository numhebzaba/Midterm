using System;

namespace Midterm_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfweek = int.Parse(Console.ReadLine());
            int timeOfday = int.Parse(Console.ReadLine());


            int breakFastset = 5;
            int weekEnd = 2;
            int coffee = 3;

            bool loopmenu = true;
            while (loopmenu)
            {
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "Breakfast Set":
                        if (breakFastset == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        if (timeOfday > 11)
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }
                        breakFastset--;
                        break;
                    case "Weekend Set":
                        if (weekEnd == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        if (dayOfweek < 6)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        weekEnd--;
                        break;
                    case "Coffee":
                        if (coffee == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        coffee--;
                        break;
                    case "End":
                        loopmenu = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;
                }
            }

        }
    }
}
