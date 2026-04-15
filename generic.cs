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

class Genericeg
{
    static void Main(string[] args)
    {
        Test<int> obj = new Test<int>();

        obj.addItem(20);
        obj.addItem(30);
        obj.addItem(40);
        obj.addItem(50);
        obj.addItem(60);
        obj.addItem(70); // triggers overflow

        obj.displayItem();

        Console.ReadKey();
    }
}