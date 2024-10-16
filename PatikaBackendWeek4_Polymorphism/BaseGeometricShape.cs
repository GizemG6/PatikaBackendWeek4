public class BaseGeometricShape // base class for geometric shapes
{
    // properties
    public double Width { get; set; }
    public double Height { get; set; }

    public virtual double CalculateArea() // virtual method for calculating area
    {
        return Height * Width;
    }
}

public class Square : BaseGeometricShape // derived class for square
{
    public override double CalculateArea() // override method for square area 
    {
        return Width * Width; // both width ang height are the same
    }
}

public class Rectangle : BaseGeometricShape // derived class for rectangle
{
    // no need to override
}

public class RightTriangle : BaseGeometricShape // derived class for right triangle
{
    public override double CalculateArea()
    {
        return (Width * Height) / 2; // override method for right triangle
    }
}