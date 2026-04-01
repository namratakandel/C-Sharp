using System;
class MyClass
{
private int x;
public void SetX(int i)
{
x=i;
}
public int GetX()
{
return x;
}
}
class Client
{
public static void Main(String[] args)
{
MyClass c= new MyClass();
c.SetX(10);
int val=c.GetX();
Console.WriteLine($"value={val});
}
}