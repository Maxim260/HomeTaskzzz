/*Программа,принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве*/

Console.Clear();
Console.Write(" ENTER координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" ENTER координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" ENTER координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" ENTER координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" ENTER координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" ENTER координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Результат = {Math.Round(S,2)}");