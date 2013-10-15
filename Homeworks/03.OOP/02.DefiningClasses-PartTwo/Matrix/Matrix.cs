using System;
using System.Text;

// 8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    private T[,] matrix;
    private int rows;
    private int cols;

    // Constructor
    public Matrix(int rows, int cols)
    {
        T type = default(T);
        if (!((type is double) || (type is int) || (type is decimal)))
        {
            throw new ApplicationException("T must be (double, int or decimal)");
        }
        else
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }
    }

    // 9. Implement an indexer this[row, col] to access the inner matrix cells.
    public T this[int row, int col]
    {
        get
        {
            if (isInRange(row, col))
            {
                return this.matrix[row, col];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }
        set
        {
            if (isInRange(row, col))
            {
                this.matrix[row, col] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }
    }

    // 10. Implement the operators +
    public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
    {
        if ((first.rows != second.rows) || (first.cols != second.cols))
        {
            // 10.1 Throw an exception when the operation cannot be performed.
            throw new ApplicationException("The matrices must have the same size!");
        }

        Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);

        for (int i = 0; i < first.rows; i++)
        {
            for (int j = 0; j < first.cols; j++)
            {
                resultMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
            }
        }

        return resultMatrix;
    }

    // 10.2 Implement the operators -
    public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
    {
        if ((first.rows != second.rows) || (first.cols != second.cols))
        {
            throw new ApplicationException("The matrices must have the same size!");
        }

        Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);

        for (int i = 0; i < first.rows; i++)
        {
            for (int j = 0; j < first.cols; j++)
            {
                resultMatrix[i, j] = (dynamic)first[i, j] - second[i, j];
            }
        }

        return resultMatrix;
    }

    // 10.3 Implement the operators *
    public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
    {
        if (first.cols != second.rows)
        {
            throw new ApplicationException("The matrices must have the same size!");
        }

        Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
        for (int i = 0; i < first.rows; i++)
        {
            for (int j = 0; j < first.cols; j++)
            {
                for (int k = 0; k < first.cols; k++)
                {
                    resultMatrix[i, j] += (dynamic)first[i, k] * second[k, j];
                }
            }
        }

        return resultMatrix;
    }

    // 10.4 Implement the true operator
    public static bool operator true(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.cols; j++)
            {
                if ((dynamic)matrix[i, j] != default(T))
                {
                    return true;
                }
            }
        }

        return false;
    }

    // 10.5 Implement the false operator
    public static bool operator false(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.cols; j++)
            {
                if ((dynamic)matrix[i, j] != default(T))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool isInRange(int row, int col)
    {
        if ((row < 0) || (row >= this.rows) || (col < 0) || (col >= this.cols))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string ToString()
    {
        StringBuilder format = new StringBuilder();

        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.cols; j++)
            {
                format.AppendFormat("{0,3}", this[i, j]);
            }

            format.AppendLine();
        }

        return format.ToString();
    }
}