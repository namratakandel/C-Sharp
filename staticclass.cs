using System;
class MyCollege
{
    public static String collegename;
    public static String address;
    static MyCollege()
    {
        collegename="Lumbini ict campus";
        address="Gaindakot,Nawalpur";
    }

}
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine($"College Name:{MyCollege.collegename}");
        Console.WriteLine($"Address:{MyCollege.address}");
    }
}