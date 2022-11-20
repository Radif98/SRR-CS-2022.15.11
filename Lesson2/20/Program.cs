// Определить номер четверти плоскости, в которой находится точка с координатами Х и У
// причем X ≠ 0 и Y ≠ 0
System.Console.Write("введите X: ");
double X=Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("введите Y: ");
double Y=Convert.ToInt32(Console.ReadLine()); 

if (X>0 & Y>0)
    {
     System.Console.WriteLine("1");
    }
if (X<0 & Y>0)
    {
    System.Console.WriteLine("2");
    }
if (X<0 & Y<0)    
    {
    System.Console.WriteLine("3");    
    }
if (X>0 & Y<0)
    {
    System.Console.WriteLine("4");
    }    