using System;

class MatrixTest
{
    static void Main()
    {
        Matrix<int> matrixA = new Matrix<int>(3, 3);
        Matrix<int> marixB = new Matrix<int>(3, 3);

        Random rand = new Random();
        matrixA[0, 0] = rand.Next(1, 5); matrixA[0, 1] = rand.Next(1, 5); matrixA[0, 2] = rand.Next(1, 5);
        matrixA[1, 0] = rand.Next(1, 5); matrixA[1, 1] = rand.Next(1, 5); matrixA[1, 2] = rand.Next(1, 5);
        matrixA[2, 0] = rand.Next(1, 5); matrixA[2, 1] = rand.Next(1, 5); matrixA[2, 2] = rand.Next(1, 5);

        marixB[0, 0] = rand.Next(1, 5); marixB[0, 1] = rand.Next(1, 5); marixB[0, 2] = rand.Next(1, 5);
        marixB[1, 0] = rand.Next(1, 5); marixB[1, 1] = rand.Next(1, 5); marixB[1, 2] = rand.Next(1, 5);
        marixB[2, 0] = rand.Next(1, 5); marixB[2, 1] = rand.Next(1, 5); marixB[2, 2] = rand.Next(1, 5);

        Console.WriteLine("Adding:");
        Console.WriteLine(matrixA);
        Console.WriteLine("+");
        Console.WriteLine(marixB);
        Console.WriteLine("=");
        Console.WriteLine(matrixA + marixB);

        Console.WriteLine("Subtracting:");
        Console.WriteLine(matrixA);
        Console.WriteLine("-");
        Console.WriteLine(marixB);
        Console.WriteLine("=");
        Console.WriteLine(matrixA - marixB);

        Console.WriteLine("Multiplying:");
        Console.WriteLine(matrixA);
        Console.WriteLine("*");
        Console.WriteLine(marixB);
        Console.WriteLine("=");
        Console.WriteLine(matrixA * marixB);

        Console.WriteLine("Comparing:");
        if (matrixA == marixB)
        {
            Console.WriteLine("First matrix = Second matix");
        }
        else
        {
            Console.WriteLine("First matrix != Second matix");
        }
    }
}