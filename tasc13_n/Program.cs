// Tasc13
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.Write("No");
else 
{
    while (n > 1000)
        n = (n / 10);
        Console.Write(n % 10);
}
