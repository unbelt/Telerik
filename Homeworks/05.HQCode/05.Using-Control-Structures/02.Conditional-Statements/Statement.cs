using System;

/* Refactor the following if statements */

public class Statement
{
    public static void Main()
    {
        Potato potato;

        if (potato == null)
        {
            throw new ArgumentNullException();
        }

        if (potato.IsPeeled == true && potato.IsRotten == false)
        {
            Cook(potato);
        }

        bool isCellVisited;

        if (x >= MIN_X && x <= MAX_X &&
            y >= MIN_Y && y <= MAX_Y && 
            isCellVisited == false)
        {
            VisitCell();
        }
    }
}