using System;

abstract class Mcn
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Mcn1 : Mcn
{
    public int Mul(int a, int b)
    {
        return a * b;
    }
}

class Test
{
    static void Main(string[] args)
    {
        Mcn1 obj = new Mcn1();

        int r1 = obj.Add(5, 10);
        int r2 = obj.Mul(5, 10);

        Console.WriteLine("Addition = " + r1);
        Console.WriteLine("Multiplication = " + r2);

        Console.ReadKey();
    }
}