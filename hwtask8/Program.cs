//Напишите программу,которая на вход принимает число (И),
//а на выходе показывает все чётные числа от 1 до И.

        Console.Clear();
        Console.Write("Enter the number:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= n; i+=2)
            // if (i % 2 == 0)
                Console.Write($"{i}; ");
