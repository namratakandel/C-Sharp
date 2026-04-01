using System;

// Parent class
class Vehicle
{
    public void Wheeler()
    {
        Console.WriteLine("This is a vehicle");
    }
}

// Child class (inherits Vehicle)
class Bike : Vehicle
{
    public void TwoWheeler()
    {
        Console.WriteLine("This is a two wheeler");
    }
}

// Child of Bike (multilevel inheritance)
class TVS : Bike
{
    public void Raider()
    {
        Console.WriteLine("This is TVS Raider bike");
    }
}

class Program
{
    static void Main()
    {
        TVS obj = new TVS();

        obj.Wheeler();      // from Vehicle
        obj.TwoWheeler();  // from Bike
        obj.Raider();      // from TVS

        Console.ReadKey();
    }
}