// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class CardDeck
{
    static void Main()
    {
        // Loop for cards
        for (int cards = 2; cards <= 14; cards++)
        {
            // Loop for colors
            for (int colors = 1; colors <= 4; colors++)
            {
                switch (cards)
                {
                    case 2:
                        Console.Write("Two of ");
                        break;
                    case 3:
                        Console.Write("Three of ");
                        break;
                    case 4:
                        Console.Write("Four of ");
                        break;
                    case 5:
                        Console.Write("Five of ");
                        break;
                    case 6:
                        Console.Write("Six of ");
                        break;
                    case 7:
                        Console.Write("Seven of ");
                        break;
                    case 8:
                        Console.Write("Eight of ");
                        break;
                    case 9:
                        Console.Write("Nine of ");
                        break;
                    case 10:
                        Console.Write("Ten of ");
                        break;
                    case 11:
                        Console.Write("King of ");
                        break;
                    case 12:
                        Console.Write("Queen of ");
                        break;
                    case 13:
                        Console.Write("Knave of ");
                        break;
                    case 14:
                        Console.Write("Ace of ");
                        break;
                    default:
                        Console.Write("Ops..");
                        break;
                }
                switch (colors)
                {
                    case 1: Console.Write("Spades");
                        break;
                    case 2: Console.Write("Hearts");
                        break;
                    case 3: Console.Write("Diamonds");
                        break;
                    case 4: Console.Write("Clubs" + Environment.NewLine);
                        break;
                    default: Console.WriteLine("Ops..");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}