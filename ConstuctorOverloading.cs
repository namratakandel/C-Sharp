using System;
class Employee
{
public String Name;
public int Age;
public double Salary;

//Default Constructor
public Employee()
{
Name = "Unknown";
Age = 0;
Salary = 0.0;
}

//Constructor with 2 parameter
public Employee(String name, int age)
{
Name = name;
Age = age;
Salary = 0.0;
}

//Constructor with 3 parameter
public Employee(String name, int age, double salary)
{
Name = name;
Age = age;
Salary = salary;
}
public void Display()
{
Console.WriteLine($"Name:{Name}, Age:{Age}, Salary:{Salary}");
}
}
class Program
{
static void Main()
{
Employee emp1 = new Employee();
Employee emp2 = new Employee("Namrata",20);
Employee emp3 = new Employee("Namrata",20,15000);
emp1.Display();
emp2.Display();
emp3.Display();
}
}
