using System;

class EvenNumbers
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("Even numbers from 1 to 50 are:");

        do
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
            i++;
        } while (i <= 50);
    }
}