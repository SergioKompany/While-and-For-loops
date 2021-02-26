using System;

namespace For_task_7__Rhomb_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select the diameter of a rhomb (>2):");
            int diameter = int.Parse(Console.ReadLine());
            int result = (diameter % 2);
            if (diameter < 3)
            {
                Console.WriteLine("This rhomb cannot be built");
            }
            else if (result == 1)
            {
                Console.WriteLine("This rhomb is odd");
                int contrdiamfall = (diameter - 1) / 2;
                int y = 1;
                for (; y <= diameter; y += 2)
                {
                    int z = contrdiamfall;
                    for (; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                    contrdiamfall--;
                    for (int x = 1; x <= y; x++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                int contrdiammax = (diameter - 1) / 2;
                for (int u = diameter - 2; u >= 1 ; u-=2)
                {
                    int contrdiamgrow = contrdiammax + 1 - (u + 1) / 2;
                    int c = contrdiammax - contrdiamgrow;
                    for (; c < contrdiammax; c++)
                    {
                        Console.Write(" ");
                    }
                    contrdiamgrow++;
                    for (int x = u; x >= 1; x--)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            else if (result == 0)
            {
                Console.WriteLine("This rhomb is even");
                int contrdiam = (diameter / 2) - 1;
                int y = 2;
                for (; y <= diameter; y += 2)
                {
                    int z = contrdiam;
                    for (; z > 0; z--)
                    {
                        Console.Write(" ");
                    }
                    contrdiam--;
                    for (int x = 1; x <= y; x++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
                int contrdiametermax = diameter/2 - 1;
                int u = diameter;
                int contrdiameter = diameter/2 - u/2;
                for (; u >= 2; u-=2)
                {
                    int z = contrdiametermax - contrdiameter;
                    for (; z < contrdiametermax; z++)
                    {
                      Console.Write(" ");
                    }
                    contrdiameter++;
                    for (int x = u; x > 0; x--)
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
