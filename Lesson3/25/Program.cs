// Вывести на экран кубы чисел от 1 до N
// Задача цикл, нет смысла усложнять подпрограммой 
Console.Write("Введите N:");
int N = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Число" + "\t" + "Куб");
{
for(int i = 1; i <= N; i++)
Console.WriteLine(i + "\t" + i*i*i);
}
