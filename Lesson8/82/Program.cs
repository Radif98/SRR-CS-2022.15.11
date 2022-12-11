// C клавиатуры вводится строка разделенная точкой. 
//Подсчитать количество символов до точки

string s=Console.ReadLine();
{
int k=0;
char a='.';

for(int i=0;i<s.Length;i++)
    {
        if(char.IsAscii(s[i])) k++;
        if(s[i]==a) break;
    }
     
System.Console.WriteLine(k-1);       
}