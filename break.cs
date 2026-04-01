using System;
class BreakLoop
{
static void Main()
{
for(int i=0;i<100;i++)
{
if (i==10)
{
break ; }
Console.WriteLine("i:" + i);
}
Console.WriteLine("loop completed");
}
}

 