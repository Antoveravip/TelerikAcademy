namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {  
        public static void Main()
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] mineFields = PutMines();
            int count = 0;
            bool isMine = false;
            List<Score> bestScores = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool newGame = true;
            const int MaxNotMinedFields = 35;
            bool foundAllMines = false;

            do
            {
                if (newGame)
                {
                    Console.WriteLine("Let's play Minesweeper. Try yout luck to find all fields without mines.");
                    Console.WriteLine("Commands:{0}'top' show scores,{0}'restart' - new game,{0}'exit' - leave the game!", Environment.NewLine);
                    GenerateBoard(gameField);
                    newGame = false;
                }

                Console.Write("Type row and column number: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        {
                            ShowScores(bestScores);
                            break;
                        }

                    case "restart":
                        {
                            gameField = CreateGameField();
                            mineFields = PutMines();
                            GenerateBoard(gameField);
                            isMine = false;
                            newGame = false;
                            break;
                        }

                    case "exit":
                        {
                            Console.WriteLine("Bye bye. Better luck next time!");
                            break;
                        }

                    case "turn":
                        {
                            if (mineFields[row, column] != '*')
                            {
                                if (mineFields[row, column] == '-')
                                {
                                    GetTurn(gameField, mineFields, row, column);
                                    count++;
                                }

                                if (MaxNotMinedFields == count)
                                {
                                    foundAllMines = true;
                                }
                                else
                                {
                                    GenerateBoard(gameField);
                                }
                            }
                            else
                            {
                                isMine = true;
                            }

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("{0}Wrong! Invalid command!{0}", Environment.NewLine);
                            break;
                        }
                }

                if (isMine)
                {
                    GenerateBoard(mineFields);
                    Console.Write("{0}BOOM! You step at mine and was blown away with {1} points.{0} Write your nickname: ", Environment.NewLine, count);
                    string nickname = Console.ReadLine();
                    Score playerScore = new Score(nickname, count);

                    if (bestScores.Count < 5)
                    {
                        bestScores.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < bestScores.Count; i++)
                        {
                            if (bestScores[i].Points < playerScore.Points)
                            {
                                bestScores.Insert(i, playerScore);
                                bestScores.RemoveAt(bestScores.Count - 1);
                                break;
                            }
                        }
                    }

                    bestScores.Sort((Score firstResult, Score secondResult) => secondResult.Name.CompareTo(firstResult.Name));
                    bestScores.Sort((Score firstResult, Score secondResult) => secondResult.Points.CompareTo(firstResult.Points));
                    ShowScores(bestScores);

                    gameField = CreateGameField();
                    mineFields = PutMines();
                    count = 0;
                    isMine = false;
                    newGame = true;
                }

                if (foundAllMines)
                {
                    Console.WriteLine("{0}Well done! You open all 35 cells without step on mine.", Environment.NewLine);
                    GenerateBoard(mineFields);

                    Console.WriteLine("Write your name, hero: ");
                    string name = Console.ReadLine();
                    Score playerScore = new Score(name, count);
                    bestScores.Add(playerScore);
                    ShowScores(bestScores);
                    gameField = CreateGameField();
                    mineFields = PutMines();
                    count = 0;
                    foundAllMines = false;
                    newGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Come back later.");
            Console.Read();
        }

        private static void ShowScores(List<Score> points)
        {
            Console.WriteLine(Environment.NewLine + "Points:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scores!" + Environment.NewLine);
            }
        }

        private static void GetTurn(char[,] field, char[,] mines, int row, int column)
        {
            char mineNumbers = CalculateSurroundingMines(mines, row, column);
            mines[row, column] = mineNumbers;
            field[row, column] = mineNumbers;
        }

        private static void GenerateBoard(char[,] board)
        {
            int numberOfRows = board.GetLength(0);
            int numberOfColumns = board.GetLength(1);
            Console.WriteLine(Environment.NewLine + "    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   --------------------- " + Environment.NewLine);
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);

                if (!mines.Contains(asfd))
                {
                    mines.Add(asfd);
                }
            }

            foreach (int mine in mines)
            {
                int mineCol = mine / columns;
                int mineRow = mine % columns;

                if (mineRow == 0 && mine != 0)
                {
                    mineCol--;
                    mineRow = columns;
                }
                else
                {
                    mineRow++;
                }

                gameField[mineCol, mineRow - 1] = '*';
            }

            return gameField;
        }
        
        private static char CalculateSurroundingMines(char[,] field, int fieldRow, int fieldCol)
        {
            int mineCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (fieldRow - 1 >= 0)
            {
                if (field[fieldRow - 1, fieldCol] == '*')
                {
                    mineCounter++;
                }
            }

            if (fieldRow + 1 < rows)
            {
                if (field[fieldRow + 1, fieldCol] == '*')
                {
                    mineCounter++;
                }
            }

            if (fieldCol - 1 >= 0)
            {
                if (field[fieldRow, fieldCol - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (fieldCol + 1 < columns)
            {
                if (field[fieldRow, fieldCol + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((fieldRow - 1 >= 0) && (fieldCol - 1 >= 0))
            {
                if (field[fieldRow - 1, fieldCol - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((fieldRow - 1 >= 0) && (fieldCol + 1 < columns))
            {
                if (field[fieldRow - 1, fieldCol + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((fieldRow + 1 < rows) && (fieldCol - 1 >= 0))
            {
                if (field[fieldRow + 1, fieldCol - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((fieldRow + 1 < rows) && (fieldCol + 1 < columns))
            {
                if (field[fieldRow + 1, fieldCol + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }
    }
}