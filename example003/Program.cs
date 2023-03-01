// Найти сумму цифр числа

int SumNumbers(int number)
{
    if (number < 1) return 0;
    else return SumNumbers(number/10) + number % 10;
}

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(number));