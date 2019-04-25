using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main code for the TicTacToe game
            string playerNameA = "";
            string playerNameB = "";
            char playerSymbolA = 'x';
            char playerSymbolB = 'o';
            char[,] board = new char[3, 3]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            Console.Write("Enter the name of player A:");
            playerNameA = Console.ReadLine();
            Console.Write("Enter the name of player B:");
            playerNameB = Console.ReadLine();
            bool gameOver = false;
            while ( !gameOver)
            {
                Console.Clear();
                DrawBoard(board);

                Console.ReadKey();
            }
        }
        static void DrawBoard(char [,] board)
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
             
                    Console.Write(board[i, j]);
             
                Console.WriteLine();
            }
        }

    }
}
