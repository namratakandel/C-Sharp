using System.Collections.Generic;
using System;
class Program
{
    //generic method
    static void swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        Console.WriteLine("Before swapping: x={0}, y={1}", x, y);
        swap<int>(ref x, ref y);
        Console.WriteLine("After swapping: x={0}, y={1}", x, y);

        string str1 = "Hello", str2 = "World";
        Console.WriteLine("Before swapping: str1={0}, str2={1}", str1, str2);
        swap<string>(ref str1, ref str2);
        Console.WriteLine("After swapping: str1={0}, str2={1}", str1, str2);

        Console.ReadKey();
    }`