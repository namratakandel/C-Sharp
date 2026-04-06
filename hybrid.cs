using System;

// Base Class
class Polygon
{
    public int dim1, dim2;

    public void ReadDimensions(int dim1, int dim2)
    {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
}

// Derived Class (Level 1)
class Rectangle : Polygon
{
    public void AreaRe()
    {
        int area = dim1 * dim2;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}

// Derived Class (Level 2 - Multilevel)
class Square : Rectangle
{
    public void AreaSq()
    {
        int area = dim1 * dim1;
        Console.WriteLine("Area of Square: " + area);
    }
}

// Another Derived Class (Hierarchical)
class Triangle : Polygon
{
    public void AreaTr()
    {
        double area = 0.5 * dim1 * dim2;
        Console.WriteLine("Area of Triangle: " + area);
    }
}

// Main Class
class Hybrid
{
    static void Main(string[] args)
    {
        // Triangle (Hierarchical)
        Triangle tr = new Triangle();
        tr.ReadDimensions(10, 5);
        tr.AreaTr();

        // Rectangle (Level 1)
        Rectangle re = new Rectangle();
        re.ReadDimensions(10, 5);
        re.AreaRe();

        // Square (Multilevel)
        Square sq = new Square();
        sq.ReadDimensions(5, 5);
        sq.AreaSq();

        Console.ReadKey();
    }
}