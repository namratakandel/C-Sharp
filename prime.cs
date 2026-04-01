using System;
class Program
{
static void Main()
{
int num,i;
for (num=2;num<=10;num++)
{
bool isPrime= true;
for(i=2;i<num;i++)
{
if(num%i==0)
{
isPrime=false;
break;
}
}

if(isPrime)
{
Console.WriteLine(num);
}
}
}
}

