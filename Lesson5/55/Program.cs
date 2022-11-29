// Написать программу масштабирования фигуры
// Рассмотрим вариант для фигуры из 4 координат 

int[] Array(int p)
{
int[] t=new int[p];
for(int i=0;i<p;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
    return t; 
}

void Print(int[] t)
{
    for(int i=0;i<t.Length;i++)
        System.Console.WriteLine($"x\ny{t[i],10}");

           
}

/*void PrintXY(int[] t)
{
    for(int i=0;i<t.Length;i++)
        System.Console.WriteLine(" x \n y");

}
*/
System.Console.Write("Введите количество координат N:");
int n=Convert.ToInt32(Console.ReadLine());
int p=n*2;
/*System.Console.Write("Введите масштаб фигуры:");
int k=Convert.ToInt32(Console.ReadLine());
double x=x*k;
double y=y*k;*/
int[] a=Array(n);
//PrintXY(a);
Print(a);
