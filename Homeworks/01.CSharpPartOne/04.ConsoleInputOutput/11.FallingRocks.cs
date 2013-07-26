using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{
    class FallingRocks
    {
        static int dwarfPosition;
        static char[,] gameField;
        static char[] rockTypes = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        static Random randomGenerator = new Random();
        static bool endOfGame;
        static int score;

        static void InitializeGameField()
        {
            // increases with each line of falling rocks
            Console.SetWindowSize(30, 30);  // you can set your size here...
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            score = -Console.WindowHeight + 1;
            Console.ForegroundColor = ConsoleColor.Green;

            gameField = new char[Console.WindowHeight, Console.WindowWidth];
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = ' ';
                }
            }
            dwarfPosition = Console.WindowWidth / 2;
            gameField[gameField.GetLength(0) - 1, dwarfPosition - 1] = '(';
            gameField[gameField.GetLength(0) - 1, dwarfPosition] = 'O';
            gameField[gameField.GetLength(0) - 1, dwarfPosition + 1] = ')';

        }
        static void MoveDwarfLeft()
        {
            if (dwarfPosition > 1)
            {
                dwarfPosition--;
                gameField[gameField.GetLength(0) - 1, dwarfPosition + 2] = ' ';
                gameField[gameField.GetLength(0) - 1, dwarfPosition - 1] = '(';
                gameField[gameField.GetLength(0) - 1, dwarfPosition] = 'O';
                gameField[gameField.GetLength(0) - 1, dwarfPosition + 1] = ')';

            }
        }
        static void MoveDwarfRight()
        {
            if (dwarfPosition < gameField.GetLength(1) - 3)
            {
                dwarfPosition++;
                gameField[gameField.GetLength(0) - 1, dwarfPosition - 2] = ' ';
                gameField[gameField.GetLength(0) - 1, dwarfPosition - 1] = '(';
                gameField[gameField.GetLength(0) - 1, dwarfPosition] = 'O';
                gameField[gameField.GetLength(0) - 1, dwarfPosition + 1] = ')';
            }
        }
        static void MoveDwarf()
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                MoveDwarfLeft();
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                MoveDwarfRight();
            }

            //if an arrow is holded 
            //while (Console.KeyAvailable)
            //{
            //    Console.ReadKey();
            //}
            //doesn't really work because dwarf "jumps" because Console.ReadKey() moves the cursor
        }

        static void DrawField()
        {
            Console.Clear();
            for (int i = 0; i < gameField.GetLength(0); i++)     //without last line for dwarf
            {
                //TODO: Random colors 
                byte color = (byte)randomGenerator.Next(6);
                for (int j = 0; j < gameField.GetLength(1) - 1; j++)
                {
                    Console.Write(gameField[i, j]);
                }
                if (i == gameField.GetLength(0) - 1)
                {
                    continue;
                }
                Console.WriteLine();
            }
        }

        static char[] GenerateRocks()
        {
            byte numberOfRocksPerLine = (byte)randomGenerator.Next(1, 4);
            char[] rocks = new char[Console.WindowWidth - 1];
            for (int i = 0; i < rocks.GetLength(0); i++)
            {
                rocks[i] = ' ';
            }
            for (int i = 0; i < numberOfRocksPerLine; i++)
            {

                byte arrIndex = (byte)randomGenerator.Next(0, Console.WindowWidth - 1);
                byte typeIndex = (byte)randomGenerator.Next(0, rockTypes.Length - 1);
                rocks[arrIndex] = rockTypes[typeIndex];
            }
            return rocks;
        }

        static void GameCycle()
        {
            while (!endOfGame)
            {
                //redraw rocks
                if (
                    (gameField[Console.WindowHeight - 2, dwarfPosition] != ' ') ||
                    (gameField[Console.WindowHeight - 2, dwarfPosition - 1] != ' ') ||
                    (gameField[Console.WindowHeight - 2, dwarfPosition + 1] != ' ')
                    )
                {
                    endOfGame = true;
                }
                else
                {
                    score++;
                }

                for (int i = Console.WindowHeight - 2; i > 0; i--)
                {
                    for (int j = 0; j < Console.WindowWidth - 1; j++)
                    {
                        gameField[i, j] = gameField[i - 1, j];
                    }

                }
                char[] rocks = GenerateRocks();
                for (int i = 0; i < gameField.GetLength(1) - 1; i++)
                {
                    gameField[0, i] = rocks[i];
                }
                DrawField();
                Thread.Sleep(150);
            }
        }
        static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("You're dead! Your score is {0} ", score);
            string deadSmiley = @"
   _                   _
 _( )                 ( )_
(_, |      __ __      | ,_)
   \'\    /  ^  \    /'/
    '\'\,/\      \,/'/'
      '\| []   [] |/'
        (_  /^\  _)
          \  ~  /
          /HHHHH\
        /'/{^^^}\'\
    _,/'/'  ^^^  '\'\,_
   (_, |           | ,_)
     (_)           (_) 

";
            //some ascii art here
            Console.WriteLine(deadSmiley);
            Console.WriteLine("Press Esc to exit!");
            ConsoleKeyInfo escKey;
            do
            {
                escKey = Console.ReadKey();
            } while (escKey.Key != ConsoleKey.Escape);
            Environment.Exit(0);

        }

        static void Main(string[] args)
        {
            InitializeGameField();
            Console.WriteLine("Welcome to the Matrix! \nUse arrows to move" +
            "\nPress any key to start \nPress Esc to quit");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            Thread inputThread = new Thread(delegate()
            {
                while (true)
                {
                    MoveDwarf();
                }
            });
            inputThread.IsBackground = true;
            inputThread.Start();
            GameCycle();
            EndGame();
            Console.Clear();
        }
    }
}