using System;
class cde
{
public int a {get;set;}
public int b {get;set;}
public int Sum
{
get {return a+b;}
}
}
class Test
{
static void Main()
{
cde obj = new cde
();
obj.a= 10;
obj.b= 5;
Console.WriteLine("Sum of"+obj.a+"and"+obj.b+"="+obj.Sum);
Console.ReadKey();
}
}
