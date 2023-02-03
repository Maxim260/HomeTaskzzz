Console.Clear();
Console.WriteLine("ATTENTION!Программа выводит только третью цифру числа!");
Console.Write("Enter a number here-> ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
Console.WriteLine("В вашем числе нет третьей цифры:(.Попробуйте ещё ");
else
{
while (a >= 999)
{
    a /= 10;
}
Console.WriteLine($"Congratulations!!!You got a number): {a % 10}");
}