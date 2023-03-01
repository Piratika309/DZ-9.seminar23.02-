// Найти сумму элементов от M до N, N и M заданы

int Sum (int M, int N)
{
if (M == N) return N;
else return M + Sum(M+1, N);
}
Console.WriteLine("Введите число, от которого будет вестись отсчет: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, до которого будет вестись отсчет: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(M, N));
