// Tasc2
Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
int max = n;
if (m > max)
    Console.Write($"max = {m}");
else 
    Console.Write($"max = {n}");