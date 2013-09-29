using System;
using System.Text.RegularExpressions;

public class Display
{
    // Field
    private float? displaySize;
    private int? displayColors;

    // Constructor
    public Display(float? size, int? colors)
    {
        this.displaySize = size;
        this.displayColors = colors;
    }
    public Display()
    {
    }
    public Display(float? size)
        : this(size, null)
    {
    }
    public Display(int? colors)
        : this(null, colors)
    {
    }

    // Properties
    public float? DisplaySize
    {
        get { return this.displaySize; }
        set
        {
            if (!Regex.IsMatch(value.ToString(), "^[0-9]{1,25}$"))
            {
                throw new ArgumentException("Display size must be a positive number!");
            }

            this.displaySize = value;
        }
    }

    public int? NumberOfColors
    {
        get { return this.displayColors; }
        set
        {
            if (!Regex.IsMatch(value.ToString(), "^[0-9]{1,5000}$"))
            {
                throw new ArgumentException("Display colors must be a positive number!");
            }

            this.displayColors = value;
        }
    }

    // Formatting
    public override string ToString()
    {
        return string.Format("Size: {0}\" \r\nColors: {1}M", this.displaySize, this.displayColors);
    }
}