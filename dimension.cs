class Rectangular
{
static void Main(string[] args)
{
int[,] vals= new int[4,2]{
{9,99},
{3,33},
{4,44},
{1,11}
};
for(int i=0;i<4;i++)
{
for(int j=0; j<2;j++)
{
Console.WriteLine(vals[i,j]);
}
}
Console.ReadKey();
}
}