// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int a = 1;
int p = 1;

while (a <= N)
{
    p = p * a;
    a++;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равно {p}");

