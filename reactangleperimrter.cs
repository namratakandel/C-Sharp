using System;

// Parent class
class Rectangle
{
    protected int l, b;
    public void Values(int length, int breadth)
    {
        l = length;
        b = breadth;
        Console.WriteLine($"Length: {l}, Breadth: {b}");
    }
}

// Child class
class ChildR : Rectangle
{
    public void Area()
    {
        int area = l * b;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}

class Program
{
    static void Main()
    {
        ChildR obj = new ChildR();

        obj.Values(5, 4);  // set values
        obj.Area();        // calculate area

        Console.ReadKey();
    }
}