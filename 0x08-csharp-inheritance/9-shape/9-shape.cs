using System;

///<summary>Initial class for shapes</summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Rectangle class inheriting from Shape</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get { return width; }
        set { width = (value < 0) ? throw new ArgumentException("Width must be greater than or equal to 0") : value;}
    }
    public int Height
    {
        get { return height; }
        set { height = (value < 0) ? throw new ArgumentException("Height must be greater than or equal to 0") : value;}
    }

    public override int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return String.Format("[Rectangle] {0} / {1}", width, height);
    }
}

///<summary>Square class inheriting from Rectangle</summary>
class Square : Rectangle
{
    private int size;

    public int Size
    {
        get { return size; }
        set { Height = Width = size = (value < 0) ? throw new ArgumentException("Size must be greater than or equal to 0") : value;}
    }

    public override string ToString()
    {
        return String.Format("[Square] {0} / {1}", size, size);
    }
}
