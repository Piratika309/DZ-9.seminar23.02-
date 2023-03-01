// Написать программу вычисления функции Аккермана

int result( int n, int m)
{
    if(n == 0) return m + 1;
    else if ((n > 0) && (m == 0)) return result(n-1,1);
    else return result(n - 1, result(n, m - 1));
}

Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine(result(n,m));