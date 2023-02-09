// TASK41.Пользователь вводит с клавиатуры М чисел. Посчитайте,сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Сколько чисел вы введёте?: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите задуманные числа,а я посчитаю сколько чисел из них чётные: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.Write($"Колличество чётных чисел из введённых вами: {count}");