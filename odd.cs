using System;

class OddNumbers
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("Odd numbers from 1 to 50 are:");

        while (i <= 50)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
            i++;
        }
    }
}