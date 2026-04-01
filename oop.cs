using System;
namespace OOPDemo
{
public class Student
{
private int id;
private String name;
public void Setdata(int i,String n)
{
id = i;
name=n;
}
public void DisplayData()
{
Console.WriteLine("student Id:="+id);
Console.WriteLine("student name:= "+name);
}
}
class Program
{
static void Main(String[] args)
{
student s1 = new student();
S1.SetData (101."namrata");
S1.DisplayData();
Console.ReadLine();
}
}
}

