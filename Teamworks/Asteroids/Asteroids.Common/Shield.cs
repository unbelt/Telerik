namespace Asteroids.Common
{
    using System;

    public class Shield
    {
        public Shield(char orientation, int len, Ship ship) // Shield orientation
        {
            this.Orientation = orientation;
            this.Len = len;

            if (this.Orientation == 'L' || this.Orientation == 'R')
            {
                this.View = "|";

                // Set left || right shield
                if (this.Orientation == 'L')
                {
                    this.XPos = ship.XPos - 2;
                    this.YPos = ship.YPos;
                }
                else
                {
                    this.XPos = ship.XPos + 2;
                    this.YPos = ship.YPos;
                }
            }
            else
            {
                this.View = "—";

                // Set top || bottom shield
                if (this.Orientation == 'U')
                {
                    this.XPos = ship.XPos;
                    this.YPos = ship.YPos - 1;
                }
                else
                {
                    this.XPos = ship.XPos;
                    this.YPos = ship.YPos + 1;
                }
            }
        }

        // Properties
        public char Orientation
        {
            get;
            set;
        }

        public int Len
        {
            get;
            set;
        }

        public int XPos
        {
            get;
            set;
        }

        public int YPos
        {
            get;
            set;
        }

        public string View
        {
            get;
            set;
        }

        public void Draw()
        {
            int x = this.XPos;
            int y = this.YPos;

            for (int i = 0; i < this.Len; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(this.View);

                if (this.Orientation == 'U' || this.Orientation == 'D')
                {
                    x += 1;
                }
                else
                {
                    y += 1;
                }
            }
        }

        // TODO: Remove duplication
        public void Clear()
        {
            int x = this.XPos;
            int y = this.YPos;
            for (int i = 0; i < this.Len; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(' ');

                if (this.Orientation == 'U' || this.Orientation == 'D')
                {
                    x += 1;
                }
                else
                {
                    y += 1;
                }
            }
        }
    }
}
