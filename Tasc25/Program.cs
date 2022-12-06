Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = n;
for (int i = 1; i < m; i++)
    result = result * n;
Console.Write(result);
