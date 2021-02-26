using System;

namespace While_task_1__Rectangle_and_Square_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Select a number of rows:");
            int RowsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a number of columns:");
            int ColumnsCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int y = 0;
            while (y < ColumnsCount)
            {
                int x = 0;
                while (x < RowsCount)
                {
                    Console.Write(symbol + " ");
                    x++;
                }
                y++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
