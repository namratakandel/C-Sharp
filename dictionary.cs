using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Step 1: Create Dictionary
        Dictionary<int, string> dobj = new Dictionary<int, string>();

        // Step 2: Add values
        dobj.Add(1, "Sabin");
        dobj.Add(2, "Sudesh");
        dobj.Add(3, "Smriti");
        dobj.Add(4, "Amir");
        dobj.Add(5, "Sapan");

        // Step 3: Display values using loop
        for (int i = 1; i <= dobj.Count; i++)
        {
            Console.WriteLine(dobj[i]);
        }

        // Step 4: Wait for key press
        Console.ReadKey();
    }
}