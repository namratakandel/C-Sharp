using System;
class Student
{
public int id, age;
public String name, subject;
public Student(int id, String name, int age, String subject)
{
this.id = id;
this.name = name;
this.subject = subject;
this.age = age;
}
public void showInfo()
{
Console.WriteLine(id+" "+name+" "+age+" "+subject+" ");
}
}
class studentDetails
{
public static void Main(String[]args)
{
Student std1 = new Student(001,"Namrata",20,"Dotnet");
std1.showInfo();
}
}

