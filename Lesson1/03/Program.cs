// С клавиатуры вводяhttps://docs.google.com/document/d/18PIF4POYbGC0Q3rZWVIODJey-7iBrMvgylAL_kuekbI/edit?usp=sharingтся два числа a и b. Найти максимальное из них.
System.Console.Write("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (a>b)
{
    System.Console.WriteLine($"{a} -является максимальным числом");
} 
else 
{
    System.Console.WriteLine($"{b}  -является максимальным числом");
}
