using System;

namespace While_task__directed_triangle__2_and_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the length of a triangle:");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a direction (+/-):");
            string direction = Console.ReadLine();
            Console.WriteLine();
            if (direction == "+")
            {
                int y = 1;
                while (y <= Length)
                {
                    int x = 1;
                    while (x <= y)
                    {
                        Console.Write(symbol);
                        x++;
                    }
                    y++;
                    Console.WriteLine();
                }

            }
            else if (direction == "-")
            {
                int y = Length;
                while (y >= 1)
                {
                    int x = y;
                    while (x >= 1)
                    {
                        Console.Write(symbol);
                        x--;
                    }
                    y--;
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("You have inserted a wrong character for a direction!");
            }
            Console.ReadLine();
        }
    }
}
