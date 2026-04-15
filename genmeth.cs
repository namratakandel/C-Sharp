using System;
using System.Collections.Generic;

class Test<T>
{
    T[] t = new T[5];
    int c = 0;

    public void addItem(T item)
    {
        if (c < 5)
        {
            t[c] = item;
            c++;
        }
        else
        {
            Console.WriteLine("Overflow exists");
        }
    }

    public void displayItem()
    {
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine("Item at index {0} is {1}", i, t[i]);
        }
    }
}

class Program
{
    // Generic Swap Method
    static void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        // Swap Example
        int a = 40, b = 60;

        Console.WriteLine("Before swap: {0}, {1}", a, b);
        Swap<int>(ref a, ref b);
        Console.WriteLine("After swap: {0}, {1}", a, b);

        Console.WriteLine();

        // Generic Class Example
        Test<int> obj = new Test<int>();

        obj.addItem(10);
        obj.addItem(20);
        obj.addItem(30);

        obj.displayItem();

        Console.ReadLine();
    }
}