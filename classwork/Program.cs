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
