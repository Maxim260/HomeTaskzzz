// // task 17

// Console.Clear();
// Console.Write("Введите координату X:  ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y:  ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0 || y == 0)
// {
// Console.WriteLine("ВЫ ОШИБЛИСЬ!Введите координату заново!");
// Console.Write("Введите координату X:  ");
// x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y:  ");
// y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y> 0)
// Console.WriteLine("I");
// else if (x < 0 && y > 0)
// Console.WriteLine("II");
// else if (x < 0 && y < 0)
// Console.WriteLine("III");
// else 
// Console.WriteLine("IV");

/* Задача 18. Программа показывает диапоазон 
возможных координат по заданному номеру четверти*/

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int a = Convert.ToInt32(Console.ReadLine());
// while (a < 1 || a > 4)
// {
//     Console.WriteLine("Вы ошиблись!\nВведите число от 1-4: ");
//     a = Convert.ToInt32(Console.ReadLine());
// }
// if (a == 1)
//     Console.WriteLine("x(0,+∞)and y(0,+∞)");
// else if (a == 2)
//     Console.WriteLine("x(0,-∞) and y(0,+∞)");
// else if (a == 3)
//     Console.WriteLine("x(0,-∞) and y(0,-∞)");
// else
//     Console.WriteLine("x(0,+∞) and y(0,-∞)");

/*Задача 21. Программа которая принимает на вход координаты двух точек 
 и находит расстояние между ними в 2Д пространстве*/

// Console.Clear();
// Console.Write("Введите x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)),2); // Round -округляет до 2 знаков.Pow-возводит в степень 2
// Console.WriteLine(l);

/*Задача 22. Программа принимаетт число(N) и выдаёт таблицу квадратов чисел от 1 до N.*/

// Console.Clear();
// Console.Write("Введите Number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
//     Console.Write($"{Math.Pow(i, 2)} ");