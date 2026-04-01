using System;
class Miscoperator
{
static void Main()
{
//size of operator
Console.WriteLine("Size of int:"+sizeof(int));
Console.WriteLine("Size of double:"+sizeof(double));
//type of operator
Type t = typeof(String);
Console.WriteLine("Type of String"+t);
//is operator
object num = 50;
if(num is int)
{
Console.WriteLine("num is an integer");

 
}
//console operator?;
int a = 10,b=20;
int max = (a>b)?a:b;
Console.WriteLine("maximum is :"+max);
}
}






