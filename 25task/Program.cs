/* Задача25. Напишите цикл,который принимает на вход два числа А и В 
 и возводит исло А в натуральную стеень В.*/

Console.Clear();
Console.Write(" ENTER 1-th number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" ENTER 2-th number: ");
int m = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= m; i++)
    result = result * n; //result *= n;
Console.WriteLine(result);