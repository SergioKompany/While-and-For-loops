using System;

namespace While_task_2__Triangle_grow_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select a length of a growing triangle:");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine();
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
            Console.ReadLine();
        }
    }
}
