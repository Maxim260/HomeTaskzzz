// task 17

Console.Clear();
Console.Write("Введите 1-ое число X:  ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 1-ое число Y:  ");
double y = Convert.ToDouble(Console.ReadLine());
while (x == 0 || y == 0)
{
Console.WriteLine("ВЫ ОШИБЛИСЬ!Введите координату заново!");
Console.Write("Введите 1-ое число X:  ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 1-ое число Y:  ");
y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y> 0)
Console.WriteLine("I");
else if (x < 0 && y > 0)
Console.WriteLine("II");
else if (x < 0 && y < 0)
Console.WriteLine("III");
else 
Console.WriteLine("IV");