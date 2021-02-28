using System;

namespace For_task_8__Static_Pythagoras_
{
    class Program
    {
        static void Main(string[] args)
        {
            //This table looks perfect unless x or y is up to 100
            int HorStart = 1;
            int HorFinish = 12;
            int VerStart = 1;
            int VerFinish = 15;
            int x = HorStart;
            int y = VerStart;
            Console.WriteLine("Static Pythagoras Table");
            Console.Write("--+");
            for (x = HorStart; x <= HorFinish; x++)
            {
                Console.Write("----");
            }
            Console.Write("+");
            Console.WriteLine();
            Console.Write("  |");
            for (x = HorStart; x <= HorFinish; x++)
            {
               if (x < 10)
                {
                Console.Write("   " + x);
                }
                else if (x >= 10)
                {
                Console.Write("  " + x);
                }
            }
            Console.Write("|");
            Console.WriteLine();
            Console.Write("--+");
            for (x = HorStart; x <= HorFinish; x++)
            {
                Console.Write("----");
            }
            Console.Write("+");
            Console.WriteLine();
            for (y = VerStart; y <= VerFinish; y++)
            {
                if (y < 10)
                {
                Console.Write(" " + y + "|");
                }
                else if (y >= 10)
                {
                    Console.Write(y + "|");
                }
                for (x = HorStart; x <= HorFinish; x++)
                {
                    int product = x * y;
                    if (product >= 100)
                    {
                        Console.Write(" " + product);
                    }
                    else if (product >= 10)
                    {
                        Console.Write("  " + product);
                    }
                    else if (product >= 0)
                    {
                        Console.Write("   " + product);
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }
                Console.Write("--+");
                for (x = HorStart; x <= HorFinish; x++)
                {
                    Console.Write("----");
                }
            Console.Write("+");
            Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
