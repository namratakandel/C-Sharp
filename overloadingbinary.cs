using System;

class Complex
{
    private int x;
    private int y;

    // Default constructor
    public Complex()
    {
        x = 0;
        y = 0;
    }

    // Parameterized constructor
    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }

    // Display method
    public void ShowXY()
    {
        Console.WriteLine("{0} {1}", x, y);
    }

    // Operator Overloading (+)
    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.x = c1.x + c2.x;
        temp.y = c1.y + c2.y;
        return temp;
    }
}

class Program
{
    public static void Main()
    {
        Complex c1 = new Complex(10, 20);
        c1.ShowXY();

        Complex c2 = new Complex(20, 30);
        c2.ShowXY();

        Complex c3 = c1 + c2;
        c3.ShowXY();
    }
}
