using System;
class Program
{
static void Main()
{
char grade;
Console.WriteLine("Enter your grade(A/B/C/D/E):");
grade= Convert.ToChar(Console.ReadLine().ToUpper());
switch(grade)
{
case'A':
Console.WriteLine("Excellent");
break;
case'B':
Console.WriteLine("very good");
break;
case'C':
Console.WriteLine("good");
break;
case'D':
Console.WriteLine("needs improvement");
break;
case'E':
Console.WriteLine("fail");
break;
default:
Console.WriteLine("invalid garde");
break;
}
}
}




