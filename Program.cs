using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            //bool endgame = false;
            int movesPlayed = 0;
            Initialize(board);

            //The game plays until win/lose/draw
            while (true)
            {
                Console.Clear();
                Print(board);

                Console.Write("Please Enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = player;

                //check if win!!

                // left to right row 0
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                // left to right row 1
                if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                // left to right row 2
                if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                // *CORNER CHECK (left to right)
                if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }
                // *CORNER CHECK (left to right)
                if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                // UPDOWN col 0
                if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                // UPDOWN col 1
                if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                // UPDOWN col 2
                if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.WriteLine("player " + player + " WIN!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                    //Console.ReadKey(); //halt program execution until press any key
                }

                player = ChangeTurn(player);

                //draw game
                movesPlayed = movesPlayed + 1;

                if (movesPlayed == 9)
                {
                    Console.WriteLine("DRAW!!!");
                    Console.WriteLine();
                    Console.WriteLine("Final Result: ");
                    Print(board);
                    break;
                }

                //Celebration for winner
                // clear the screen
                // print the board
                // Mention who won or if it was draw
            }
        }

        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return '0';
            }

            else
                return 'X';
        }

        static void Initialize(char[,] board)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c] = ' ';
                }
            }
        }
        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int r = 0; r < 3; r++)
            {
                Console.Write(r + " | ");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(board[r, c]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
