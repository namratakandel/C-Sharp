using System;
static class Author
{
    public static String fname="kamal";
    public static String Lname="sapkota";
    public static int Tno=39;
    public static void details()
    {
        Console.WriteLine("The details of the author is:");
        
    }
}
public class GFG
{
    static public void Main()
    {
        Author.details();
        Console.WriteLine($" Author First Name:{Author.fname}");
        Console.WriteLine($" Author Last Name:{Author.Lname}");
        Console.WriteLine($"Author Telephone Number:{Author.Tno}");
    }
}
