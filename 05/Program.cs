// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.Write("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число c:");
double c=Convert.ToDouble(Console.ReadLine());

if (a>b)
{
    if (a>c)
    
        { 
            System.Console.WriteLine($"{a} -является максимальным числом");
        } 
    else 
        { 
            System.Console.WriteLine($"{c} -является максимальным числом");
        }      
}
else 
    if (b>c)
    {
        System.Console.WriteLine($"{b} -является максимальным числом");
    }
    else
    {
        System.Console.WriteLine($"{c} -является максимальным числом");
    }
    
    
    
    
     