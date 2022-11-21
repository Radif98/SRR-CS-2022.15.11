// Подсчитать сумму цифр в числе. Сделать подпрограмму.
int Summa(int Number)
{
    Number=Math.Abs(Number);
    int Sum=Number%10;
    if (Number==0) Sum=0;
    while (Number>0)
    {
        Number=Number/10;
        Sum=Sum+Number%10;
    }
    return Sum;
}

Console.Write("Введите N:");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summa(N));