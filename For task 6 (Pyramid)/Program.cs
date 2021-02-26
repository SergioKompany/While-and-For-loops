using System;

namespace For_task_6__Pyramid_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the length of a pyramid's basis (>2):");
            int basis = int.Parse(Console.ReadLine());
            int result = (basis % 2);
            if (basis < 3)
            {
                Console.WriteLine("This pyramid cannot be built");
            }
            else if (result == 1)
            {
                Console.WriteLine("This pyramid is odd");
                int contrbas = (basis - 1) / 2;
                int y = 1;
                for (; y <= basis; y += 2)
                {
                    int z = contrbas;
                    for (; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                    contrbas--;
                    for (int x = 1; x <= y; x++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            else if (result == 0)
            {
                Console.WriteLine("This pyramid is even");
                int contrbas = (basis / 2) - 1;
                int y = 2;
                for (; y <= basis; y += 2)
                {
                    int z = contrbas;
                    for (; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                    contrbas--;
                    for (int x = 1; x <= y; x++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
