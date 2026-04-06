using System;   
abstract class test1
{
    public int add(int i, int j)
    {
        return i + j;
    }
    public abstract int mul(int i, int j);

}
class test2 : test1
{
    public override int mul(int i, int j)
    {
        return i * j;
    }
}
class test3 :test1
{
    public override int mul(int i, int j)
    {
        return i * j ;
    }
}
class myClass
{
    public static void Main(string[] args)
    {
        test2 obj = new test2();
        int r1 = obj.add(5, 10);
        int r2 = obj.mul(5, 10);
        Console.WriteLine("Addition = " + r1);
        Console.WriteLine("Multiplication = " + r2);

        test3 obj1 = new test3();
        int r3 = obj1.add(5, 10);
        int r4 = obj1.mul(5, 10);
        Console.WriteLine("Addition = " + r3);
        Console.WriteLine("Multiplication = " + r4);

        Console.ReadKey();
    }
}