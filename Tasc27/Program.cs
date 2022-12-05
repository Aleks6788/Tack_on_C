
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
    int x = n % 10;
    result = result +  x;
    n = n / 10;
}
Console.WriteLine($"Результат: {result}");




