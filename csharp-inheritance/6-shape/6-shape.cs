using System;

/// <summary>
/// Class Shape/// 
/// </summary>
public class Shape
{
    /// <summary>
    /// Area method
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Class Rectangle
/// </summary>
public class Rectangle : Shape
{
    /// <summary>
    /// Private fields
    /// </summary>
    private int width;
    private int height;

    /// <summary>
    /// Constructor
    /// </summary>
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0.");
            width = value;
        }
    }

    /// <summary>
    /// Height///
    /// </summary>
    /// <value></value>//  
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0.");
            height = value;
        }
    }
}
