namespace TicTacToe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = 9;
            char[][] ch = new char[n][]; //??

            for (int i = 0; i < n; i++)//??
            {
                ch[i] = new char[n];//??
            }//??

            bool winner = false;
            bool isFree;
            int currentPlayer = 1;
            string playerChar = "X0";

            int row = -1;
            int col = -1;


            while (!winner)
            {
                Console.Clear();

                Console.Write(" ");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("_____ ");
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("|     ");
                    }
                    Console.WriteLine("|");

                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("|  " + ch[i][j] + "  ");
                    }
                    Console.WriteLine("|");

                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("|_____");
                    }
                    Console.WriteLine("|");
                }

                Console.WriteLine("Player " + currentPlayer + " " + playerChar[currentPlayer - 1]);

                isFree = false;
                while (!isFree)
                {
                    Console.Write($"Row 0-{n - 1} ");
                    string userRow = Console.ReadLine();
                    row = int.Parse(userRow);

                    while (row >= n)
                    {
                        Console.WriteLine($"Error! Row insert 0-{n - 1} ");
                        Console.Write($"Row 0-{n - 1} ");
                        userRow = Console.ReadLine();
                        row = int.Parse(userRow);
                    }

                    Console.Write($"Column 0-{n - 1} ");
                    string userCol = Console.ReadLine();
                    col = int.Parse(userCol);
                    while (col >= n)
                    {
                        Console.WriteLine($"Error! Column insert 0-{n - 1} ");
                        Console.Write($"Row 0-{n - 1} ");
                        userCol = Console.ReadLine();
                        col = int.Parse(userCol);
                    }

                    if (ch[row][col] == 'X' || ch[row][col] == '0')  //char empty ???
                    {
                        Console.WriteLine("Error! Busy");

                    }
                    else
                    {
                        isFree = true;
                    }

                }

                ch[row][col] = playerChar[currentPlayer - 1];


                var currentPlayerChar = playerChar[currentPlayer - 1];
                // tox
                for (int i = 0; i <= n - 3; i++)
                {
                    if (ch[row][i] == currentPlayerChar && ch[row][i + 1] == currentPlayerChar && ch[row][i + 2] == currentPlayerChar)
                    {
                        winner = true;
                        break;
                    }
                }

                if (!winner)
                {
                    for (int j = 0; j <= n - 3; j++)
                    {
                        if (ch[j][col] == currentPlayerChar && ch[j + 1][col] == currentPlayerChar && ch[j + 2][col] == currentPlayerChar)
                        {
                            winner = true;
                            break;
                        }
                    }
                }

                if (!winner)
                {
                    for (int i = 0; i <= n - 3; i++)
                    {
                        for (int j = 0; j <= n - 3; j++)
                        {
                            if (ch[i][j] == currentPlayerChar && ch[i + 1][j + 1] == currentPlayerChar && ch[i + 2][j + 2] == currentPlayerChar)
                            {
                                winner = true;
                                break;
                            }
                        }
                    }
                }


                if (!winner)
                {
                    for (int i = 2; i < n; i++)
                    {
                        for (int j = 0; j <= n - 3; j++)
                        {
                            if (ch[i][j] == currentPlayerChar && ch[i - 1][j + 1] == currentPlayerChar && ch[i - 2][j + 2] == currentPlayerChar)
                            {
                                winner = true;
                                break;
                            }
                        }
                    }
                }


                if (!winner)
                {
                    if (currentPlayer == 1)
                    {
                        currentPlayer = 2;
                    }
                    else
                    {
                        currentPlayer = 1;
                    }
                }
            }

            Console.WriteLine($"Winner Player " + currentPlayer);
        }

    }
}
