// Вывести на экран таблицу квадратов чисел от 1 до N
// Задача на цикл, по этому не стал усложнять подпрограммой
 
Console.Write("Введите N:");
int N = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Число" + "\t" + "Квадрат");
{
for(int i = 1; i <= N; i++)
Console.WriteLine(i + "\t" + i*i);
}

  
    