using System;
class Program
{
static void Main()
{
 Console.WriteLine("Enter Fisrt number");
 string a = Console.ReadLine();
 int num1 = int.Parse(a);
 
 Console.WriteLine("Enter second number");
 int num2 = int.Parse(Console.ReadLine());
 int sum = num1 + num2;
 int diff = num1 - num2;
 int product = num1*num2;
 Console.WriteLine("The sum of {0}and{1} is {2}", num1,num2,sum);
 Console.WriteLine("The diffrence of {0}and{1} is {2}", num1,num2,diff);
 Console.WriteLine("The product of {0}and{1} is {2}", num1,num2,product);


 }
 }