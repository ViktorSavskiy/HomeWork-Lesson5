Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
}
Console.WriteLine(string.Join(", ", array));

double maxNum = array[0];
double minNum = array[0];
foreach (double el in array)
{
    if (el > maxNum)
    {
        maxNum = el;
    }
    if (el < minNum)
    {
        minNum = el;
    }
}
Console.Write("Разница между максимальным значением массива и минимальным: ");
Console.WriteLine(maxNum - minNum);