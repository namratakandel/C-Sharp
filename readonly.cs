using System;
class Student
{
//readonly
public readonly int id; 
public Student(int i)
{
id = i;
}
public void Show()
{
//id=200;
Console.WriteLine("student Id="+id);
}
}
class Program
{
static void Main()
{
Student S1 = new Student(101);
S1.Show();
Console.ReadLine();
}
}

