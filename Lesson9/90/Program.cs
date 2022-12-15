﻿/*90. Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
//Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
Пример:
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
cd
выходные данные:
1, 7, 0, 1
 
То есть, 2 бита, потом еще 3 бита, потом еще 3 бита и еще 1 бит. Переводим биты в десятичное представление.
Какие ошибки могут возникнуть при обработке наборов данных?
*/
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];
int k = 0; // счетчик количества цифр в data
for (int i = 0; i < info.Length; i++) //разбываем data на числа в двоичном коде на основе количества бит из info
{
    for (int j = 0; j < info[i]; j++)
    {
        Console.Write(data[k + j] + " ");
    }
    k += info[i];
    Console.Write("; ");
}

k = 0;
for (int i = 0; i < info.Length; i++) // преобразуем получившиеся числа из 2-ой в 10-ую
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += data[k + j] * (int)Math.Pow(2, info[i] - 1 - j);
    }
    k += info[i];
}
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}











