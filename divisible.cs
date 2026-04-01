using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 || number % 5 == 0)
        {
            Console.WriteLine("The number is divisible by 7 or 5.");
        }
        else
        {
            Console.WriteLine("The number is not divisible by 7 or 5.");
        }

        Console.ReadLine();
    }
}
