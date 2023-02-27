// Показать натуральные числа от M до N, N и M заданы

string Numbers (int M, int N)
{
if ( M <= N) return $"{M}" + " " + Numbers (M+1, N);
else return string.Empty;
}

Console.WriteLine("Введите число, от которого будет вестись отсчет: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, до которого будет вестись отсчет: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Numbers(M,N));
