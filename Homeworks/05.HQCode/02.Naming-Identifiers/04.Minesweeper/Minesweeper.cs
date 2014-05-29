namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {
        public const int GAME_ROWS = 5;
        public const int GAME_COLUMNS = 10;
        public const int MAX_SCORE = 35;

        public static void Main(string[] args)
        {
            string userInput = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] boardMines = CreateBoardMines();
            int playerScore = 0;
            bool isMineExploded = false;
            int maxHighScores = 6;
            List<GameScore> highScores = new List<GameScore>(maxHighScores);
            int gameBoardRows = 0;
            int gameBoardColumn = 0;
            bool isGameRunning = true;
            bool isAllCellsOpened = false;

            do
            {
                if (isGameRunning)
                {
                    Console.WriteLine("Let's play “Mines”. Try to find all fields without bombs." +
                    "Command 'top' show the rank list, 'restart' begins new game, 'exit' end the game!");

                    Render(gameField);
                    isGameRunning = false;
                }

                Console.Write("Input rows and columns for the game field: ");
                userInput = Console.ReadLine().Trim();

                if (userInput.Length == 3)
                {
                    if (int.TryParse(userInput[0].ToString(), out gameBoardRows) &&
                    int.TryParse(userInput[2].ToString(), out gameBoardColumn) &&
                        gameBoardRows < gameField.GetLength(0) && gameBoardColumn < gameField.GetLength(1))
                    {
                        userInput = "turn";
                    }
                }

                switch (userInput)
                {
                    case "top":
                        RankList(highScores);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        boardMines = CreateBoardMines();
                        Render(gameField);
                        isMineExploded = false;
                        isGameRunning = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (boardMines[gameBoardRows, gameBoardColumn] != '*')
                        {
                            if (boardMines[gameBoardRows, gameBoardColumn] == '-')
                            {
                                CreateGameField(gameField, boardMines, gameBoardRows, gameBoardColumn);
                                playerScore++;
                            }

                            if (MAX_SCORE == playerScore)
                            {
                                isAllCellsOpened = true;
                            }
                            else
                            {
                                Render(gameField);
                            }
                        }
                        else
                        {
                            isMineExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Wrong input\n");
                        break;
                }

                if (isMineExploded)
                {
                    Render(boardMines);

                    Console.Write("\nHrrrrrr! You die like a hero with {0} points. " + "Enter your nickname: ", playerScore);

                    string playerName = Console.ReadLine();
                    GameScore currentPlayerScore = new GameScore(playerName, playerScore);

                    if (highScores.Count < 5)
                    {
                        highScores.Add(currentPlayerScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].PlayerScore < currentPlayerScore.PlayerScore)
                            {
                                highScores.Insert(i, currentPlayerScore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((GameScore firstScoreRecord, GameScore secondScoreRecord) => secondScoreRecord.PlayerName.CompareTo(firstScoreRecord.PlayerName));
                    highScores.Sort((GameScore firstScoreRecord, GameScore secondScoreRecord) => secondScoreRecord.PlayerScore.CompareTo(firstScoreRecord.PlayerScore));

                    RankList(highScores);

                    gameField = CreateGameField();
                    boardMines = CreateBoardMines();
                    playerScore = 0;
                    isMineExploded = false;
                    isGameRunning = true;
                }

                if (isAllCellsOpened)
                {
                    Console.WriteLine("\nGOOOD JOB! You open 35 cels without а drop of blood.");
                    Render(boardMines);

                    Console.WriteLine("Enter your name: ");
                    string playerName = Console.ReadLine();

                    GameScore finalPlayerScore = new GameScore(playerName, playerScore);

                    highScores.Add(finalPlayerScore);
                    RankList(highScores);

                    gameField = CreateGameField();
                    boardMines = CreateBoardMines();
                    playerScore = 0;
                    isAllCellsOpened = false;
                    isGameRunning = true;
                }
            }
            while (userInput != "exit");
            Console.WriteLine("Made in Bulgaria :)!");
            Console.WriteLine("Go, Go, Go!");
            Console.Read();
        }

        private static void RankList(List<GameScore> scoreList)
        {
            Console.WriteLine("\nScore:");
            if (scoreList.Count > 0)
            {
                for (int i = 0; i < scoreList.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, scoreList[i].PlayerName, scoreList[i].PlayerScore);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The score list is empty!\n");
            }
        }

        private static void CreateGameField(char[,] gameField, char[,] boardMines, int gameBoardRows, int gameBoardColumns)
        {
            char countOfMines = ShowAllBoardMines(boardMines, gameBoardRows, gameBoardColumns);

            boardMines[gameBoardRows, gameBoardColumns] = countOfMines;
            gameField[gameBoardRows, gameBoardColumns] = countOfMines;
        }

        private static void Render(char[,] gameBoard)
        {
            int gameBoardRows = gameBoard.GetLength(0);
            int gameBoardColumn = gameBoard.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < gameBoardRows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < gameBoardColumn; j++)
                {
                    Console.Write(string.Format("{0} ", gameBoard[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
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

        private static char[,] CreateBoardMines()
        {
            char[,] gameField = new char[GAME_ROWS, GAME_COLUMNS];

            for (int i = 0; i < GAME_ROWS; i++)
            {
                for (int j = 0; j < GAME_COLUMNS; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> gameBoardCells = new List<int>();

            while (gameBoardCells.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!gameBoardCells.Contains(randomNumber))
                {
                    gameBoardCells.Add(randomNumber);
                }
            }

            foreach (int gameCell in gameBoardCells)
            {
                int gameRow = gameCell / GAME_COLUMNS;
                int gameColumn = gameCell % GAME_COLUMNS;

                if (gameColumn == 0 && gameCell != 0)
                {
                    gameRow--;
                    gameColumn = GAME_COLUMNS;
                }
                else
                {
                    gameColumn++;
                }

                gameField[gameRow, gameColumn - 1] = '*';
            }

            return gameField;
        }

        private static void GetAllBoardMines(char[,] gameField)
        {
            int gameBoardRows = gameField.GetLength(0);
            int gameBoardColumns = gameField.GetLength(1);

            for (int i = 0; i < gameBoardRows; i++)
            {
                for (int j = 0; j < gameBoardColumns; j++)
                {
                    if (gameField[i, j] != '*')
                    {
                        char boardMine = ShowAllBoardMines(gameField, i, j);
                        gameField[i, j] = boardMine;
                    }
                }
            }
        }

        private static char ShowAllBoardMines(char[,] gameField, int inputBoardRows, int inputBoardColumns)
        {
            int boardCellsCount = 0;
            int gameBoardRows = gameField.GetLength(0);
            int gameBoardCols = gameField.GetLength(1);

            if (inputBoardRows - 1 >= 0)
            {
                if (gameField[inputBoardRows - 1, inputBoardColumns] == '*')
                {
                    boardCellsCount++;
                }
            }

            if (inputBoardRows + 1 < gameBoardRows)
            {
                if (gameField[inputBoardRows + 1, inputBoardColumns] == '*')
                {
                    boardCellsCount++;
                }
            }

            if (inputBoardColumns - 1 >= 0)
            {
                if (gameField[inputBoardRows, inputBoardColumns - 1] == '*')
                {
                    boardCellsCount++;
                }
            }

            if (inputBoardColumns + 1 < gameBoardCols)
            {
                if (gameField[inputBoardRows, inputBoardColumns + 1] == '*')
                {
                    boardCellsCount++;
                }
            }

            if ((inputBoardRows - 1 >= 0) && (inputBoardColumns - 1 >= 0))
            {
                if (gameField[inputBoardRows - 1, inputBoardColumns - 1] == '*')
                {
                    boardCellsCount++;
                }
            }

            if ((inputBoardRows - 1 >= 0) && (inputBoardColumns + 1 < gameBoardCols))
            {
                if (gameField[inputBoardRows - 1, inputBoardColumns + 1] == '*')
                {
                    boardCellsCount++;
                }
            }

            if ((inputBoardRows + 1 < gameBoardRows) && (inputBoardColumns - 1 >= 0))
            {
                if (gameField[inputBoardRows + 1, inputBoardColumns - 1] == '*')
                {
                    boardCellsCount++;
                }
            }

            if ((inputBoardRows + 1 < gameBoardRows) && (inputBoardColumns + 1 < gameBoardCols))
            {
                if (gameField[inputBoardRows + 1, inputBoardColumns + 1] == '*')
                {
                    boardCellsCount++;
                }
            }

            return char.Parse(boardCellsCount.ToString());
        }
    }
}
