using System;

class GreatestNumber
{
    static void FindGreatest(int a, int b, int c, out int greatest)
    {
        if (a > b)
        {
            if (a > c)
            {
                greatest = a;
            }
            else
            {
                greatest = c;
            }
        }
        else
        {
            if (b > c)
            {
                greatest = b;
            }
            else
            {
                greatest = c;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int num3 = int.Parse(Console.ReadLine());

        int result;
        FindGreatest(num1, num2, num3, out result);

        Console.WriteLine("Greatest number is: " + result);
    }
}