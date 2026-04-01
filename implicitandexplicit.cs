// implicit and explicit conversion
using System;
class TypeConversion
{
static void Main()
{
//implicit conversion
int num = 25;
float f = num;
Console.WriteLine("Implicit Conversion(int to float:"+f);
 //Explict conversion
float value = 10.75f;
int i = (int)value;
Console.WriteLine("Explict Conversion(float to int):"+i);
}
}