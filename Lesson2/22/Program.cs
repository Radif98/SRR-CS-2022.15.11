// Программа проверяет пятизначное число на палиндромом.
Console.Write("введите число:");
int n=Convert.ToInt32(Console.ReadLine());

if (n%10==n/10000 || n/10%10==n/1000)
    {
        System.Console.WriteLine($"{n} - данное число является полиндромом");
    }

else 
    {
        System.Console.WriteLine($"{n} - данное число не является полиндромом");
    }    