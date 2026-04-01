using System;
class BreakLoop
{
static void Main()
{
int i=1;
StartLoop:
if (i<=10)
{
Console.Write(i+" ");
i++;
goto StartLoop;
}
Console.WriteLine("out of goto ");
}
}


 