using System;
class ConsDes
{
public ConsDes(String msg)
{
Console.WriteLine(msg);
}
public void Test()
{
Console.WriteLine("This is a simple method");
}
~ConsDes()
{
Console.WriteLine("This is a destructor");
Console.ReadKey();
}
}
class Construct
{
static void Main()
{
String m = "This is a Constructor";
ConsDes obj = new ConsDes(m);
obj.Test();
}
}
