using System;

namespace While_task_4__Triangle_fall_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the length of a falling triangle:");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine();
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
            Console.ReadLine();
        }
    }
}
