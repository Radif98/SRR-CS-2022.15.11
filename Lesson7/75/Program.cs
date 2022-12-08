//Написать программу вычисления функции Аккермана

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return A(n - 1, 1);
    else
        if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}
     
    Console.WriteLine(A(3,4));