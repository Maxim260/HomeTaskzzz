/*Home Work. Программа принимает число (N)
и выдает таблицу кубов чисел от 1 до N.*/

 Console.Clear();
Console.WriteLine("Выдает таблицу кубов чисел от 1 до N ");
Console.Write("Введите Number: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    Console.WriteLine($"{Math.Pow(i, 3)} ");