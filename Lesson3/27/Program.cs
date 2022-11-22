// Возведите число А в натуральную степень B используя цикл
Console.Write("Введите A:");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите B:");
int B = Convert.ToInt32(Console.ReadLine()); 
int i=2;
int K=A*A;
if (B==0) 
{
    System.Console.WriteLine("1");
}
while (i<B) 
{
    K=K*A;
    i++;
}
System.Console.WriteLine($"{K}");
