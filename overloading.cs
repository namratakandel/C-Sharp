using System;
class program
{
static int Add(int a, int b)
{
return a + b;
}
static int Add(int a, int b, int c)
{
return a + b+ c;
}
static double Add(double a,double b)
{
return a*b;
}
static void Main()
{
Console.WriteLine("sum of 2 integers:" + Add(5,10));
Console.WriteLine("sum of 3 integers:" + Add(5,6,7));
Console.WriteLine("sum of 2 floats:" + Add(3.5,4.7));
}
}
