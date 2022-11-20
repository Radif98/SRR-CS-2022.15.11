// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// Будем считать, что выходной - это воскресенье
Console.Write("введите номер дня недели:");
int n=Convert.ToInt32(Console.ReadLine());


if (n>7||n<1)
    {
        System.Console.Write($"Блин, по ходу вы ввели не то число");
    }
else  
    {       
        if (n==7)
            {
                Console.Write($"Day off");
            }
        else 
            {
                Console.Write($"Work");
            }
    }