// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
int i = 1;

while (i <= num)
{
    int cub = i * i * i;
    if (cub % 2 == 0)
    Console.WriteLine($"Куб числа {i} равен {cub}");
    i++;
}

