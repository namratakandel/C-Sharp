using System;

sealed class Test
{
    public void Message()
    {
        Console.WriteLine("Running from sealed class");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test obj = new Test();
        obj.Message();
    }
}