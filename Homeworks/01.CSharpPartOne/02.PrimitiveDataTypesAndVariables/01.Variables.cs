// Declare five variables choosing for each of them the most appropriate of the types
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
// 52130, -115, 4825932, 97, -10000.

using System;

class VariableNumbers
{
    static void Main()
    {
        ushort usVar = 52130;  /* min. 0      | max. 65535 */
        sbyte sbVar = -115;    /* min. -128   | max. 127 */
        uint uiVar = 4825932u; /* min. 0      | max. 4294967295 */
        byte bVar = 92;        /* min. 0      | max. 255 */
        short sVar = -1000;    /* min. -32768 | max. 32767 */

        /* Print the numbers on the console */
        Console.WriteLine("ushort example: " + usVar);
        Console.WriteLine("sbyte example: " + sbVar);
        Console.WriteLine("uint example: " + uiVar);
        Console.WriteLine("byte example: " + bVar);
        Console.WriteLine("short example: " + sVar + Environment.NewLine);
    }
}