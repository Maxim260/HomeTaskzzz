// Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 2);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(double[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa += matrix[i, j];
        }
        Console.WriteLine($"Результат средней арифметической: {j + 1}={Math.Round(summa / matrix.GetLength(0),4)}");//как здесь написать Round,чтобы ответ округлился ?
    }
}

Console.Clear();
Console.Write("ENTER size massiv: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);
