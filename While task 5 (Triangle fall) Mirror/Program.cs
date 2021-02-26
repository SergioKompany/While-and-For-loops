using System;

namespace While_task_5__Triangle_fall__Mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the length of a falling mirror triangle:");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int y = Length;
            int ContrLength = 0;
            while (y >= 1)
            {
                int z = Length - ContrLength;
                while (z < Length)
                {
                    Console.Write(" ");
                    z++;
                }
                ContrLength++;
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
