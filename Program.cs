using System;
using System.Threading;

namespace GameOfLife;

class Program
{
    private static Board board;

    static void Main(string[] args)
    {
        int gridSize = 0;
        bool successParsed;
        do
        {
            Console.Write("Enter the grid size (1-255), 0 for default (10)> ");
            successParsed = int.TryParse(Console.ReadLine(), out gridSize);
        } while (gridSize > 255 || !successParsed);

        Console.Clear();
        Console.Write("\x1b[3J");

        board = new Board(gridSize);

        int count = 0;
        while (true)
        {
            Console.Clear();
            count++;
            for (int i=0; i<board.GridSize; ++i)
            {
                for (int j=0; j<board.GridSize; ++j)
                {
                    if (!board.GetCellState(i,j))
                    {
                        Console.Write("\u2588\u2588");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(count);

            if (Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    break;
                }
            }
            
            Thread.Sleep(1000);
        }
    }
}
