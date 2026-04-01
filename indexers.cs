using System;
class Program
{
    class IndexerClass

{
    public String[] names= new String[5];
    public String this[int i]
    {
        get
        {
            return names[i];
        }
        set
        {
            names[i] = value;
        }
    }
}
static void Main(String[] args)
{
    IndexerClass Team = new IndexerClass();
    Team[0] = "Namrata";
    Team[1] = "Satyarth";
    Team[2] = "Satyarth";
    Team[3] = "Satyarth";
    Team[4] = "Satyarth";
    for (int i = 0; i < 5; i++ )
    {
        Console.WriteLine(Team[i]);
    }
    Console.ReadLine();
    }
}    
