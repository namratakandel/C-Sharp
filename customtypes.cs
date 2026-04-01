using System;
public class UnitConverter
{
  int ratio;
  public UnitConverter(int unitRatio)
{
 ratio= unitRatio;
}
public int Convert(int unit)
{
return unit*ratio;
}
}
class Test
{
static void Main()
{
 UnitConverter fToI = new UnitConverter(12);
 UnitConverter mTof = new UnitConverter(52800);
 Console . WriteLine(floI.Convert(30);
 Console . WriteLine(floI.Convert(100);
 Console . WriteLine(floI.Convert(mTof.Convert(1)));
}





