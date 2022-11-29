// Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

System.Console.Write("Введите b1:");
double b1=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите k1:");
double k1=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите b2:");
double b2=Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите k2:");
double k2=Convert.ToInt32(System.Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k2*x+b2;
System.Console.WriteLine($"координата пересечения двух прямых: x={x}; y={y}");