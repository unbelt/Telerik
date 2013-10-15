using System;
using System.Text;

// 5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
public class GenericList<T>
{
    // 5.1 Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    private const int DefaultCapacity = 16;
    private T[] elements;
    private int nextElement;
    private int capacity;

    public GenericList() : this(DefaultCapacity) { }

    // Return the count of the elements in the list
    public int Count
    {
        get { return this.nextElement; }
    }

    public GenericList(int capacity)
    {
        if (capacity < 0)
        {
            throw new ArgumentException("The capacity must be positive.");
        }
        else
        {
            this.elements = new T[capacity];
            this.nextElement = 0;
            this.capacity = capacity;
        }
    }

    // Indexer
    public T this[int index]
    {
        get
        {
            if (isInRange(index))
            {
                return this.elements[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }
        set
        {
            if (isInRange(index))
            {
                this.elements[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }
    }

    // 5.2 Implement methods for adding element
    public void AddElement(T element)
    {
        if (this.nextElement >= this.capacity)
        {
            Grow();
        }

        this.elements[this.nextElement] = element;
        this.nextElement++;
    }

    // 5.3 Removing element by index
    public void RemoveElementAtIndex(int index)
    {
        if (isInRange(index))
        {
            T nextElement = default(T);

            for (int i = index; i < this.elements.Length - 1; i++)
            {
                nextElement = this.elements[i + 1];
                this.elements[i] = nextElement;
            }

            this.nextElement--;
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of range!");
        }
    }

    // 5.4 Inserting element at given position
    public void InsertElementAt(int index, T element)
    {
        if (isInRange(index))
        {
            if (this.nextElement >= this.capacity)
            {
                Grow();
            }
            for (int i = this.nextElement; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.nextElement++;
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of range!");
        }
    }

    // 5.5 Clearing the list
    public void ClearList()
    {
        this.elements = new T[this.capacity];
        this.nextElement = 0;
    }

    // 5.7 Finding element by it's value
    public int FindElementValue(T value)
    {
        int index = Array.IndexOf(this.elements, value);

        if (index < 0)
        {
            Console.Write("The number doesn't exist! ");
            return -1;
        }
        else
        {
            Console.Write("The number is found at index: ");
            return Array.IndexOf(this.elements, value);
        }

    }

    // 5.8 Check all input parameters to avoid accessing elements at invalid positions.
    private bool isInRange(int index)
    {
        if (index < 0 || index >= this.nextElement)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    /* 6. Implement auto-grow functionality: when the internal array is full,
      create a new array of double size and move all elements to it. */
    private void Grow()
    {
        T[] tempList = new T[this.capacity];
        this.elements.CopyTo(tempList, 0);
        this.capacity *= 2;
        this.elements = new T[this.capacity];
        tempList.CopyTo(this.elements, 0);
    }

    // 5.6 ToString()
    public override string ToString()
    {
        StringBuilder format = new StringBuilder();

        for (int i = 0; i < this.nextElement; i++)
        {
            if (i < this.nextElement - 1)
            {
                format.Append(String.Format("{0}, ", this.elements[i]));
            }
            else
            {
                format.Append(String.Format("{0}", this.elements[i]));
            }
        }

        return format.ToString();
    }
}