Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n % 10;
int n3 = (n / 1000) % 10;
int n4 = (n / 10) % 10;
if (n1 == n2 && n3 == n4)
    Console.Write("Yes");
else 
    Console.Write("No");
    