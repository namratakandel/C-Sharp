using System;

// Parent class
class Bird
{
    public void Wings()
    {
        Console.WriteLine("Bird has wings");
    }
}

// Child class 1
class Penguin : Bird
{
    public void Swim()
    {
        Console.WriteLine("Penguin can swim");
    }
}

// Child class 2
class Eagle : Bird
{
    public void Fly()
    {
        Console.WriteLine("Eagle can fly");
    }
}

// Child class 3
class Parrot : Bird
{
    public void Eat()
    {
        Console.WriteLine("Parrot eats grains");
    }
}

class Program
{
    static void Main()
    {
        Penguin p = new Penguin();
        Eagle e = new Eagle();
        Parrot pr = new Parrot();

        p.Wings();
        p.Swim();

        e.Wings();
        e.Fly();

        pr.Wings();
        pr.Eat();

        Console.ReadKey();
    }
}