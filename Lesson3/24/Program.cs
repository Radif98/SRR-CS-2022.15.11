// Вывести на экран таблицу квадратов чисел от 1 до N
System.Console.Write("введитe N: ");
int n=Convert.ToInt32(Console.ReadLine()); 
for (int i = 1; i <= n; i++)
    {
        i=i*i;
    
        Console.WriteLine($"{i}");
    } 