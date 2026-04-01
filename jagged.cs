class Jagged
{
static void Main(String[] args)
{
int[][] jagged = new int[][]
{
new int[] {1,2},
new int[] {1,2,3},
new int[] {1,2,3,4}
};
foreach (int[] array in jagged)
{
foreach (int e in array)
{
Console.Write(e +" ");
}
Console.Write('\n');
}
Console.ReadKey();
}
}


