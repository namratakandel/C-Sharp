using System;
class User
{
static User()
{
Console.WriteLine("This is a Static Constructor");
}
public User()
{
Console.WriteLine("I am a default Constructor");
}
}
class Program
{
static void Main(String[] args)
{
User obj1 = new User();
User obj2 = new User();
Console.WriteLine("\n Press Enter to Exit:");
Console.ReadLine();
}
}
