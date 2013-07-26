// Declare two string variables and assign them with “Hello” and “World”.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class HelloWorldObject
{
    static void Main()
    {
        /* Declare two string variables */
        string hi = "Hello";
        string all = "World";

        /* Declare object variable */
        object hiAll = hi + " " + all;

        /* Initializing the sting with the value of the object variable */
        string strHiAll = (string)hiAll;

        /* Print on the console */
        Console.WriteLine("First string is = {0}" + Environment.NewLine +
                          "Second string is = {1}" + Environment.NewLine + 
                          "Object = first string + second string = {2}" + Environment.NewLine +
                          "Third string = object = {3}", hi, all, hiAll, strHiAll + Environment.NewLine);
    }
}