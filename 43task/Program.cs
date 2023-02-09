/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями у = к1*х+b1, у = к2*х+b2; значения b1,k1,b2 и k2 задаются пользователем.*/

Console.Clear();
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Результат: ({x}, {y})");