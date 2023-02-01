/*
Console.Clear();
Console.WriteLine("Hello, World!");*/
// int n = int.Parse(Console.ReadLine());
// int a=1, b=2;
// Console.WriteLine($"{a},{b}");
//Console.WriteLine($"Результат: {n * 3}");

Console.Clear();

Console.Write("Введите 1-ое число  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число  ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
Console.WriteLine(n);
else if (n < m)
Console.WriteLine(m);
else
    Console.WriteLine("=");
