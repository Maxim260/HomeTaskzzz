/*Напишиет программу которая выводит случайное число из отрезка 
10-99 и показывает наибольшую цифру числа*/

// Console.Clear();
// Console.Write("rundom number: ");
// int n = new Random().Next(10,100);// 10-99 on 1 up
// Console.WriteLine($"Chenge rundom number: {n}"); // write in termin rundom number
// int n1 = n / 10;
// int n2 = n % 10;
// if (n1 > n2)
// Console.WriteLine(n1);
// else
// Console.WriteLine(n2);

/* Task11.Напишите программу которая выводит случайное трехзначное
 число и удаляет вторую цифру этогго числа*/

// Console.Clear();
// Console.Write("rundom number: ");
// int q = new Random().Next(100,1001);
// Console.WriteLine($"Chenge rundom number: {q}");
// int q1 = q / 100;
// int q3 = q % 10;
// Console.WriteLine(q1 * 10 + q3);

/* Задача12. Программа принимает на вход два числа 
и выводит является ли второе число кратным первому.
если число 2 не кратно числу 1,
то программа выводит остаток от деления.*/

//Console.Clear();
// Console.Write("Введите 1-ое число  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число  ");
// int m = Convert.ToInt32(Console.ReadLine());
//if (n % m == 0) //если остаток при делении первого числа на второе равно 0 то -см.д.
//Console.WriteLine("yes");
//else //иначе
//Console.WriteLine($"no,remains = {n % m}"); //выводим остаток деления

/* З.№14. Программа принимает на вход число и проверяет 
кратно ли оно одновременно 7 и 23.*/

// Console.Clear();
// Console.Write("Введите число:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 ==0 && n % 23 == 0) //если Н процент 7 равен 0 и одновремнно Н % = 0
// Console.WriteLine("yes");
// else
// Console.WriteLine("no");

/* З.16. Программ принимает два числа и проверяет 
является ли одно число квадратом другого.*/

// Console.Write("Введите 1-ое число  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число  ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n*n == m || m * m == n)
// Console.WriteLine("yes");
// else
// Console.WriteLine("no");

/*                       !!!!!СЕМИНАР 4!!!! */

//string(char)

// string? stroka = Console.ReadLine();
// Console.WriteLine(Convert.ToInt32(stroka[2].ToString())*10);//функция ту стринг преобразует строку

// Console.Clear();
// Console.Write("enter massiv: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10,11);

// Console.WriteLine($"Rezult: [{string.Join(",", array)}]");// джоин объединяет элементы массива

//                                              Function(void)
// void f(ref int n)
// {
//     n = n + 5;
// }

// int n = 10;
// f(ref n);
// Console.WriteLine(n);
/* Программа принимает два числа и выводит наибольшее */
// int f(int a, int b)
// {
//     if(a > b)
//         return a;
//     return b;
// }

// int a = 10, b = 7;
// int result = f(a, b);
// Console.WriteLine(result);

/* программа принимает число и выдает сумму чисел от 1 до A */

// Console.Clear();
// Console.Write(" enter: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" Rezult: {(1 + n) / 2 * n}");

/*                            !!!Программа принимает число и выдает количество цифр в числе!!!! */
// Console.Clear();
// Console.Write(" enter: ");
// int n = Convert.ToInt32(Console.ReadLine()),count = 0;
// while( n > 0)
// {
//     n = n / 10;
//     count++;// count = count +1
// }
// Console.WriteLine(count);

/*                          Задача №28. Программа принимает число и выдает произведение чисел от 1 до Н.*/

// Console.Clear();
// Console.Write(" enter: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// for (int i = 2; i <= n; i++)
//     count = count * i;
//     Console.WriteLine(count);

/*    Программа выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. */

// Console.Clear();

// int[] array = new int[8];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0,2);

// Console.WriteLine($"Rezult: [{string.Join(",", array)}]");