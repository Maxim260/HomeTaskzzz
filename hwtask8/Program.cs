//Напишите программу,которая на вход принимает число (И),
//а на выходе показывает все чётные числа от 1 до И.

Console.Clear();
Console.Write("Enter the number:  ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
