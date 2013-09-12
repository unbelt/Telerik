namespace Asteroids.UI
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Media;
    using System.Text;
    using System.Threading;
    using Asteroids.Common;

    public class AsteroidsGame
    {
        private static int gameWidth;
        private static int gameHeight;
        private static int gameSpeed;
        private static int level;
        private static int levelCounter;
        private static int difficulty;
        private static int lives;
        private static int score;
        private static string nickname;
        private static SoundPlayer music = new SoundPlayer();

        private static void Settings() // Initial settings
        {
            // Initialize an array for the asteroids
            List<Asteroid> asteroids = new List<Asteroid>();
            level = 1;
            levelCounter = 1;
            lives = 3; // starting lives
            score = 0;

            // Our hero ship
            Ship ship = new Ship('\u2588', gameWidth / 4, gameHeight / 2, ConsoleColor.White);

            Engine(asteroids, ship); // Start the game
            GameOver(score);
            Settings();
        }

        private static void Menu() // Game menu
        {
            music = new SoundPlayer(@"pacman_beginning.wav");
            music.Play();

            // Game title
            Console.Title = "ASTEROIDS!  -=-  Game Menu";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, (Console.WindowHeight / 2) - 11);
            Console.WriteLine("╔══════════╗");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 10);
            Console.WriteLine("ASTEROIDS!");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, (Console.WindowHeight / 2) - 9);
            Console.WriteLine("╚══════════╝");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 7);
            Console.WriteLine("-= MENU =-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) - 5);
            Console.WriteLine("Play·······Enter");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) - 3);
            Console.WriteLine("Game Mode···TAB");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) - 1);
            Console.WriteLine("Load Game····L");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) + 1);
            Console.WriteLine("Ranklist·····R");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) + 3);
            Console.WriteLine("Game Info····I");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) + 5);
            Console.WriteLine("Exit········Esc");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, (Console.WindowHeight / 2) + 7);
            Console.Write("Press Key:");

            // Menu switcher
            bool commandCorrect = false;

            while (!commandCorrect)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition((Console.WindowWidth / 2) + 5, (Console.WindowHeight / 2) + 7);
                var command = Console.ReadKey();

                switch (command.Key)
                {
                    case ConsoleKey.Enter: Console.Clear();
                        commandCorrect = true;
                        difficulty = 8;
                        break;
                    case ConsoleKey.Tab: Console.Clear();
                        commandCorrect = true;
                        GameMode();
                        break;
                    case ConsoleKey.Spacebar: Console.Clear();
                        commandCorrect = true;
                        Menu();
                        break;
                    case ConsoleKey.L: Console.Clear();
                        commandCorrect = true;
                        Console.SetCursorPosition(Console.WindowWidth - 30, (Console.WindowHeight / 2) - 6);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Loading...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        LoadGame();
                        break;
                    case ConsoleKey.R: Console.Clear();
                        CurrentHighScores();
                        break;
                    case ConsoleKey.I: Console.Clear();
                        GameInfo();
                        DrawControlInfo();
                        break;
                    case ConsoleKey.Escape: Console.WriteLine("GOOD BYE!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default: Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" is incorrect!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Menu();
                        break;
                }
            }
        }

        private static void FancyText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(30);
            }
        }

        private static void GameInfo() // Game info and credits
        {
            Console.Title = "ASTEROIDS!  -=-  Game Credits";
            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.WindowWidth - 48, Console.WindowHeight - 23);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Team Scratchy:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(Console.WindowWidth - 48, Console.WindowHeight - 21);
            Console.WriteLine("Angel Dimitrov");
            Console.SetCursorPosition(Console.WindowWidth - 48, Console.WindowHeight - 19);
            Console.WriteLine("Andrey 'Rookie' Andreev");
            Console.SetCursorPosition(Console.WindowWidth - 48, Console.WindowHeight - 17);
            Console.WriteLine("Plamen Shipkovenski");
            Console.SetCursorPosition(Console.WindowWidth - 48, Console.WindowHeight - 15);
            Console.WriteLine("Karim 'Flyer' Hristov");

            Console.SetCursorPosition(Console.WindowWidth - 48, Console.WindowHeight - 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"
In ASTEROIDS!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            FancyText(@"
it's all about defense.
You have a shield
and a base, and you must
defend that base against
asteroids flying toward you.
If you're not fast enough,
you are dead...
               Good luck!");

            Console.SetCursorPosition(Console.WindowWidth - 49, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Space to go back");
        }

        private static void GameMode() // Game level mode
        {
            Console.Title = "ASTEROIDS!  -=-  Game Mode";
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, Console.WindowHeight - 18);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Easy·····1");

            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, Console.WindowHeight - 15);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Normal···2");

            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, Console.WindowHeight - 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insane···3");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 6, (Console.WindowHeight / 2) + 6);
            Console.Write("Press Key:");

            Console.SetCursorPosition(Console.WindowWidth - 49, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Space to go back");

            bool commandCorrect = false;

            while (!commandCorrect)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition((Console.WindowWidth / 2) + 5, (Console.WindowHeight / 2) + 5);
                var command = Console.ReadKey();

                switch (command.Key)
                {
                    case ConsoleKey.D1: Console.Clear();
                        difficulty = 8;
                        commandCorrect = true;
                        break;
                    case ConsoleKey.D2: Console.Clear();
                        difficulty = 6;
                        commandCorrect = true;
                        break;
                    case ConsoleKey.D3: Console.Clear();
                        difficulty = 4;
                        commandCorrect = true;
                        break;
                    case ConsoleKey.Spacebar: Console.Clear();
                        commandCorrect = true;
                        Menu();
                        break;
                    default: Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" is incorrect!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        GameMode();
                        break;
                }
            }
        }

        private static void SaveGame() // Save current game
        {
            try
            {
                StreamWriter writer = new StreamWriter("SavedGames.ast");

                using (writer)
                {
                    writer.WriteLine(score);
                    writer.WriteLine(lives);
                    writer.WriteLine(level);
                    writer.WriteLine(gameSpeed);
                }
            }
            catch (Exception)
            {
                Console.SetCursorPosition(Console.WindowWidth - 40, (Console.WindowHeight / 2) - 6);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SAVE GAME FAILED!");
                Thread.Sleep(2000);
                Console.Clear();
                Menu();
            }
        }

        private static void LoadGame() // Load game
        {
            try
            {
                StreamReader reader = new StreamReader("SavedGames.ast");

                using (reader)
                {
                    score = int.Parse(reader.ReadLine());
                    lives = int.Parse(reader.ReadLine());
                    level = int.Parse(reader.ReadLine());
                    gameSpeed = int.Parse(reader.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.SetCursorPosition(Console.WindowWidth - 33, (Console.WindowHeight / 2) - 6);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("LOAD GAME FAILED!");
                Thread.Sleep(2000);
                Console.Clear();
                Menu();
            }
        }

        private static void CurrentHighScores() // Show current high score
        {
            Console.Title = "ASTEROIDS!  -=-  Ranklist";
            var highScores = File.ReadAllLines("score.ast");
            for (int i = 0; i < highScores.Length && i <= 10; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - 7, (Console.WindowHeight - 23) - (i + 1));
                Console.WriteLine("{0}. {1}", i + 1, highScores[i]);
            }

            Console.CursorVisible = false;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 12, Console.WindowHeight - 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Space to go back");
        }

        private static void Engine(List<Asteroid> asteroids, Ship ship) // V6 Supercharged
        {
            char shieldOrientetion = 'L';

            while (lives > 0)
            {
                shieldOrientetion = PressedKey(shieldOrientetion);

                if (levelCounter == difficulty)
                {
                    // Control the asteroid creation
                    Asteroid newAsteroid = new Asteroid(PickUpChar(), ConsoleColor.Cyan);
                    if (newAsteroid.Symbol == '\u263A')
                    {
                        newAsteroid.Color = ConsoleColor.Yellow;
                    }

                    if (newAsteroid.Symbol == '\u2665')
                    {
                        newAsteroid.Color = ConsoleColor.Red;
                    }

                    asteroids.Add(newAsteroid);
                    levelCounter = 0;
                }

                levelCounter++;

                Shield shield = new Shield(shieldOrientetion, 1, ship);

                // Move the asteroids
                for (int index = 0; index < asteroids.Count; index++)
                {
                    asteroids[index].Clear();
                    asteroids[index].Move();
                }

                Collisions(asteroids, ship, shield);

                ship.Draw();
                shield.Draw();

                DrawInterface(lives, score); // draw score and lives in separated cells

                // Slow down the game
                Thread.Sleep(gameSpeed);
                shield.Clear();
            }
        }

        private static void Collisions(List<Asteroid> asteroids, Ship ship, Shield shield) // Shield && Ship
        {
            // Collisions with ship
            for (int i = 0; i < asteroids.Count; i++)
            {
                if (ship.IsHittedBy(asteroids[i]))
                {
                    if (asteroids[i].Symbol == 'о' || asteroids[i].Symbol == 'O' || asteroids[i].Symbol == '0')
                    {
                        music = new SoundPlayer(@"AsteroidHit.wav");
                        music.Play();
                        DrawElement((Console.BufferWidth / 2) + 13 + lives - 1, 4, '\u2665'.ToString(), ConsoleColor.Black);
                        lives--; // loses lives only if hitted by asteroids
                    }

                    asteroids.Remove(asteroids[i]);
                    if (lives == 0)
                    {
                        break;
                    }
                }

                asteroids[i].Print();
            }

            // Collisions with shield
            for (int i = 0; i < asteroids.Count; i++)
            {
                if (asteroids[i].IsShieldHitted(shield))
                {
                    music = new SoundPlayer("ShieldHitAsteroid.wav");
                    music.Play();

                    if (asteroids[i].Symbol == '\u263A')
                    {
                        score += 9;
                        music = new SoundPlayer("Smile.wav");
                        music.Play();
                    }
                    else if (asteroids[i].Symbol == '\u2665')
                    {
                        if (lives < 6)
                        {
                            lives++;
                        }
                        else
                        {
                            score += 19;
                        }

                        music = new SoundPlayer("Heart.wav");
                        music.Play();
                    }

                    asteroids.RemoveAt(i);
                    score++; // increase current score

                    // Change the difficulty depending on the points earnt
                    if (score < 250)
                    {
                        gameSpeed = 100;
                        level = 1;
                    }
                    else if (score > 250 && score < 500)
                    {
                        gameSpeed = 75;
                        level = 2;
                    }
                    else if (score > 500 && score < 750)
                    {
                        gameSpeed = 50;
                        level = 3;
                    }
                    else if (score > 1000)
                    {
                        YouWin();
                    }
                }
            }
        }

        private static char PressedKey(char shieldOrientetion) // Shield orientation
        {
            // Left / Right / Up / Down
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    shieldOrientetion = 'L';
                }

                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    shieldOrientetion = 'R';
                }

                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    shieldOrientetion = 'U';
                }

                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    shieldOrientetion = 'D';
                }

                if (userInput.Key == ConsoleKey.Spacebar)
                {
                    // Pause game
                    Console.SetCursorPosition(Console.WindowWidth - 47, (Console.WindowHeight / 2) - 6);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" -= GAME PUSED =- ");
                    Console.SetCursorPosition(Console.WindowWidth - 48, (Console.WindowHeight / 2) - 4);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Press Space to resume");
                    Console.ReadKey();

                    if (userInput.Key == ConsoleKey.Spacebar)
                    {
                        PressedKey(shieldOrientetion);
                        Console.Clear();
                    }
                }

                if (userInput.Key == ConsoleKey.S)
                {
                    SaveGame();
                    Console.SetCursorPosition(Console.WindowWidth - 42, (Console.WindowHeight / 2) - 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GAME SAVED!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                if (userInput.Key == ConsoleKey.L)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 42, (Console.WindowHeight / 2) - 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GAME LOADED!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    LoadGame();
                }

                if (userInput.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu();
                }
            }

            return shieldOrientetion;
        }

        private static char PickUpChar() // Ramdom generator for all symbols
        {
            Random charGenerator = new Random();
            int charX = charGenerator.Next(0, 5);
            int charY = charGenerator.Next(0, 5);
            char[,] allChars = new char[,]
            {
            {
                'о', 'О', 'о', '0', 'о'
            },
                                          {
                                              'о', 'О', 'о', '0', 'о'
                                          },
                                          {
                                              'o', 'О', 'о', '0', 'o'
                                          },
                                          {
                                              'о', 'О', 'о', '0', 'о'
                                          },
                                          {
                                              '\u2665', 'о', 'о', '\u263A', 'о'
                                          },
            };
            char asteroidChar = allChars[charX, charY];
            return asteroidChar;
        }

        private static void DrawBorders() // Draw dividing line for info board
        {
            for (int i = 0; i < Console.BufferHeight; i++)
            {
                DrawElement((Console.BufferWidth / 2) + 1, i, "|", ConsoleColor.White);
                DrawElement((Console.BufferWidth / 2) + 2, i, "|", ConsoleColor.White);
            }

            for (int i = (Console.BufferWidth / 2) + 3; i < Console.BufferWidth; i += 2)
            {
                // draw lines to divide information fields
                DrawElement(i, 2, "_", ConsoleColor.White); // lines displayed under lives
                DrawElement(i, 5, "_", ConsoleColor.White);
            }
        }

        private static void DrawControlInfo() // Display the controls
        {
            DrawElement((Console.BufferWidth / 2) + 4, 8, "Controls :", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 10, '\u2191' + '\u2193'.ToString() + " Shield Up/Down", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 12, '\u2190' + '\u2192'.ToString() + " Shield Left/Right", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 14, "Space Pause/Resume", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 16, "S = Save game", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 18, "L = Load game", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 20, "\u263A", ConsoleColor.Yellow);
            DrawElement((Console.BufferWidth / 2) + 6, 20, "= +10 Score points", ConsoleColor.DarkYellow);
            DrawElement((Console.BufferWidth / 2) + 4, 22, "\u2665", ConsoleColor.Red);
            DrawElement((Console.BufferWidth / 2) + 6, 22, "= +1 Live/+20 Score", ConsoleColor.DarkYellow);
        }

        private static void DrawScore(int score) // Display the score
        {
            DrawElement((Console.BufferWidth / 2) + 4, 1, "score:" + score, ConsoleColor.Green);
        }

        private static void DrawLevels(int level) // Display the levels
        {
            DrawElement((Console.BufferWidth / 2) + 16, 1, "level:" + level, ConsoleColor.Green);
        }

        private static void DrawLives(int lives) // Display the lives
        {
            DrawElement((Console.BufferWidth / 2) + 4, 4, "lives : ", ConsoleColor.Yellow);

            for (int i = 0; i < lives; i++)
            {
                // Draw heart symbols for lives
                DrawElement((Console.BufferWidth / 2) + 13 + i, 4, '\u2665'.ToString(), ConsoleColor.Red);
            }
        }

        private static void DrawElement(int x, int y, string c, ConsoleColor color) // Draw an element
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        private static void DrawInterface(int lives, int score) // Draw all interface
        {
            DrawBorders();
            DrawScore(score);
            DrawLives(lives);
            DrawLevels(level);
            DrawControlInfo();
        }

        private static void GameOver(int score) // Gave Over screen
        {
            music = new SoundPlayer(@"explosion.wav");
            music.Play();
            Console.Clear();
            Console.Title = "ASTEROIDS!  -=-  You LOOSE!";
            DrawElement((Console.BufferWidth / 2) - 6, (Console.BufferHeight / 2) - 10, "GAME OVER", ConsoleColor.Red);
            DrawElement((Console.BufferWidth / 2) + 8, 2, "Your score:" + score, ConsoleColor.Yellow);
            DrawElement((Console.BufferWidth / 2) - 12, (Console.BufferHeight / 2) - 8, "Enter your nickname: ", ConsoleColor.Red);

            string youDeadDude = @"



             _                   _
            ( )                 ( )_
           (_, |      __ __      | _)
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
            Console.WriteLine(youDeadDude); // game Over art

            GetScore(score);
        }

        private static void YouWin() // Win Game screen
        {
            music = new SoundPlayer(@"Win.wav");
            music.Play();
            Console.Clear();
            Console.Title = "ASTEROIDS!  -=-  You WIN!";
            DrawElement((Console.BufferWidth / 2) - 5, (Console.BufferHeight / 2) - 10, "YOU WIN\n", ConsoleColor.Green);
            DrawElement((Console.BufferWidth / 2) + 8, 2, "Your score:" + score, ConsoleColor.Yellow);
            DrawElement((Console.BufferWidth / 2) - 12, (Console.BufferHeight / 2) - 8, "Enter your nickname: ", ConsoleColor.Green);

            string youWin = @"




             ╔╗╔╗╔╗╔╗
             ║╚╝╚╝║╠╣╔═╦╗╔═╦╗╔═╗╔╦╗
             ╚╗╔╗╔╝║║║║║║║║║║║╩╣║╔╝
              ╚╝╚╝ ╚╝╚╩═╝╚╩═╝╚═╝╚╝
";

            Console.WriteLine(youWin); // You Win art

            GetScore(score);
        }

        private static void GetScore(int score) // Get the final score
        {
            // Get a nickname for the high score
            Console.SetCursorPosition(34, 4);
            Console.CursorVisible = true;
            nickname = Console.ReadLine();

            int maxscore; // current high score

            try
            {
                // Export the score to file
                StreamReader reader = new StreamReader("score.ast");

                using (reader)
                {
                    string[] lineFromFile = reader.ReadLine().Split(' ');
                    maxscore = int.Parse(lineFromFile[lineFromFile.Length - 1]);
                }
            }
            catch (Exception)
            {
                maxscore = int.MinValue;
            }

            if (score >= maxscore)
            {
                // If there is new high score
                StreamWriter writer = new StreamWriter("score.ast");

                using (writer)
                {
                    writer.WriteLine(nickname + " " + score);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition((Console.WindowWidth / 2) - 13, (Console.WindowHeight / 2) - 6);
                Console.WriteLine("You have new high score!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition((Console.WindowWidth / 2) - 13, (Console.WindowHeight / 2) - 6);
                Console.WriteLine("Your score is not listed.");
            }

            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.WindowWidth - 49, Console.WindowHeight - 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Menu();
        }

        private static void Main() // Starts the program
        {
            // Environment
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            // Game title
            Console.Title = "ASTEROIDS!";

            // Window sizes
            gameWidth = 50;
            gameHeight = 25;
            gameSpeed = 100;
            Console.BufferWidth = Console.WindowWidth = gameWidth;
            Console.BufferHeight = Console.WindowHeight = gameHeight;

            Menu();
            Settings();
        }
    }
}