using System;
class program
{
static void Main()
{
int a,b;
Console.Write("enter 1st number:");
a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter 2nd number:");
b= Convert.ToInt32(Console.ReadLine());
 if(a>b)
{
Console.WriteLine("Greater number is:"+a);
}
else if(b>a)
{
Console.WriteLine("Greater number is:"+b);
}
else
{
Console.WriteLine("Both are equal");

}
}
}