// По заданному с клавиатуры номеру дня недели вывести его название
Console.Write("введите номер дня недели:");
int n=Convert.ToInt32(Console.ReadLine());
{
    if (n==1)
    {
        Console.Write($"This will Monday");
    }
    if (n==2)
    {
        Console.WriteLine($"This will Tuesday");
 
    }
     if (n==3)
    {
        Console.Write($"This will Wednesday");
    }
    if (n==4)
    {
        Console.WriteLine($"This will Thursday");
 
    }
     if (n==5)
    {
        Console.Write($"This will Friday");
    }
    if (n==6)
    {
        Console.WriteLine($"This will Saturday");
 
    }
    if (n==7)
    {
        Console.WriteLine($"This will Sunday");
 
    }
}