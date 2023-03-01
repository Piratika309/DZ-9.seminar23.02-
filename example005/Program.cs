// Написать программу возведения числа А в целую стень B

int result(int A, int B)
{
    if (B == 0) return 1;
    else return result(A, B-1)* A;
}

Console.WriteLine("Введите число, которое будет возведено в степень: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(result(A, B));