Console.Clear();
Console.Write("Please, Enter a number from 100 to 999 ");
int a = Convert.ToInt32(Console.ReadLine());
while (a >= 100)
a /= 10;
int b = a % 10;
Console.WriteLine($"Congratulations!!!You got a number): {b}");
