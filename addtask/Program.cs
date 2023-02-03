Console.Clear();
Console.WriteLine("Программа выводит второе значение по величине");
Console.WriteLine("Вводите любые числа,а в конце введите 0");
int n = Convert.ToInt32(Console.ReadLine()),max1 = n,max2 = 0;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if (n > max2)
    max2 = n;
}
Console.WriteLine(max2);