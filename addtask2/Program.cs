/* В фермерском хозяйстве в Карелии выращивают чернику. 
Она растет на круглой грядке,причем кусты высажены только по окружности. 
Таким образом,у каждого куста есть ровно два соседних.Всего на грядке растёт N кустов.
Эти кусты обладают разной урожайностью,по этому к времени сбора на них выросло различное число ягод.
 на I-ом кусте выросло а ягод.
 Внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и нескольких собирающих модулей.
 Собирающий модуль за один заход,собирает ягоды с этого куста и с двух соседних с ним.
 
 !!Напишите программу для нахождения максимального числа ягод,
 которое может собрать за один заход собирающий модуль,
 находясь перед некоторым кустом заданной во входном файле грядки.*/

 Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSumma)
        maxSumma = sum;
 }
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma) ;
maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxSumma);