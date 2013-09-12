namespace Asteroids.Common
{
    using System;
    using System.Linq;

    public class Asteroid
    {
        // Fields
        private const int PLAYFIELD = 25;
        private bool isPrinted = false;
        private int xPos;
        private int yPos;

        // Constructor
        public Asteroid(char symbol, ConsoleColor color)
        {
            this.Direction = this.GenerateRandomDirection();
            this.StartPosition(ref this.xPos, ref this.yPos, this.Direction);
            this.Symbol = symbol;
            this.Color = color;
        }

        // Properties
        public int XPos
        {
            get
            {
                return this.xPos;
            }

            set
            {
                this.xPos = value;
            }
        }

        public int YPos
        {
            get
            {
                return this.yPos;
            }

            set
            {
                this.yPos = value;
            }
        }

        public char Symbol
        {
            get;
            set;
        }

        public int Direction
        {
            get;
            set;
        }

        public ConsoleColor Color
        {
            get;
            set;
        }

        public void StartPosition(ref int xPos, ref int yPos, int direction)
        {
            if (direction == 0)
            {
                // From up
                xPos = PLAYFIELD / 2;
                yPos = 0;
            }
            else if (direction == 1)
            {
                // From right
                xPos = 25;
                yPos = PLAYFIELD / 2;
            }
            else if (direction == 2)
            {
                // From down
                xPos = PLAYFIELD / 2;
                yPos = PLAYFIELD;
            }
            else if (direction == 3)
            {
                // From left
                xPos = 0;
                yPos = PLAYFIELD / 2;
            }
        }

        public void Move()
        {
            if (this.Direction == 0)
            {
                // From up
                this.XPos = PLAYFIELD / 2;
                this.YPos += 1;
            }
            else if (this.Direction == 1)
            {
                // From right
                this.XPos -= 1;
                this.YPos = PLAYFIELD / 2;
            }
            else if (this.Direction == 2)
            {
                // From down
                this.XPos = PLAYFIELD / 2;
                this.YPos -= 1;
            }
            else if (this.Direction == 3)
            {
                // From left
                this.XPos += 1;
                this.YPos = PLAYFIELD / 2;
            }
        }

        public bool IsShieldHitted(Shield shield)  // Check if any asteroid hitted the shield
        {
            if (this.XPos == shield.XPos && this.YPos == shield.YPos)
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            if (this.isPrinted)
            {
                Console.SetCursorPosition(this.XPos, this.YPos);
                Console.Write(' ');
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(this.XPos, this.YPos);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Symbol);
            this.isPrinted = true;
        }

        // Methods
        private int GenerateRandomDirection()
        {
            Random randomGenerator = new Random();
            int direction = randomGenerator.Next(0, 4);
            return direction;
        }
    }
}
