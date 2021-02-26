using System;

namespace While_task_3__Triangle_grow__Mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the length of a growing mirror triangle:");
            int Length = int.Parse(Console.ReadLine());
            int ContrLength = Length - 1;
            Console.WriteLine();
            int y = 1;
            while (y <= Length)
            {
                int z = ContrLength;
                while (z >= 1)
                {
                    Console.Write(" ");
                    z--;
                }
                ContrLength--;
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
