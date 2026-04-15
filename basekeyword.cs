using System ;
using System.Drawing;
public class animal
{
    public string Color = "black"; 
}
public class dog : animal
{
   string Color = "white";
    public void display()
    {
        Console.WriteLine("Color of dog is {0}", Color);
        Console.WriteLine("Color of animal is {0}", base.Color);
    }
}
class Program
{
    static void Main(string[] args)
    {
        dog obj = new dog();
        obj.display();
    }
}