// Задать номер четверти, показать диапазоны для возможных координат
// Отчитываем против часовой 
System.Console.Write("введитe номер четверти: ");
double n=Convert.ToInt32(Console.ReadLine()); 


if (n==1)
        {
            System.Console.WriteLine("X - принадлежит диапазону (0;+infinity)");
            System.Console.WriteLine("Y - принадлежит диапазону (0;+infinity)");
        }

if (n==2)
        {
            System.Console.WriteLine("X - принадлежит диапазону (0;-infinity)");
            System.Console.WriteLine("Y - принадлежит диапазону (0;+infinity)");
        }

if (n==3)
        {
            System.Console.WriteLine("X - принадлежит диапазону (0;-infinity)");
            System.Console.WriteLine("Y - принадлежит диапазону (0;-infinity)");
        }

if (n==4)
        {
            System.Console.WriteLine("X - принадлежит диапазону (0;+infinity)");
            System.Console.WriteLine("Y - принадлежит диапазону (0;-infinity)");
        }

if (n<1||n>4) 
    {
        System.Console.WriteLine("Такого номера четверти не существует");   
    }