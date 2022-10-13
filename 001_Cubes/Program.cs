// Найти кубы чисел от 1 до N
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;

while (i <= N)
{
    int cub = i * i * i;
    Console.WriteLine($"Куб числа {i} равен {cub}");
    i++;
}
