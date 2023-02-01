Console.Clear();
Console.WriteLine("enter the first number:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number:  ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b)
if (a>c)

Console.WriteLine($"The number MAX: {a}");
else
Console.WriteLine($"The number MAX: {c}");
else if (b>c)
Console.WriteLine($"The number MAX: {b}");
else 
Console.WriteLine($"The number MAX: {c}");