using System;
using System.Linq;

public class InvalidRangeException<T> : ApplicationException
{
    public T Start { get; private set; }
    public T End { get; private set; }
    public new string Message = "Out of range!";

    public InvalidRangeException(T start, T end)
    {
        this.Start = start;
        this.End = end;
    }
}