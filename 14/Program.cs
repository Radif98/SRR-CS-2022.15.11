// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.Write("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());

if (a%b==0)
{
    System.Console.WriteLine($"число {a} кратно числу {b}");
} 
if (a%b!=0) 
{
    System.Console.WriteLine($"остаток от деления данных чисел= {a%b}");
}
