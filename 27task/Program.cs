//Задача27: Напишите программу,которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine()), result = 0;
while (a > 0)
{
    result = result + a % 10;
    a = a / 10;
}
Console.WriteLine(result);
