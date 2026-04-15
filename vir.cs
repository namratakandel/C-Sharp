using System;
class Vir
{
    public virtual void message()
    {
        Console.WriteLine("this is test");
    }
}
class Vir1 : Vir
{
    public override void message()
    {
        Console.WriteLine("this is test1");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Vir1 obj = new Vir1();
        obj.message();
        Console.ReadKey();
    }
}
    