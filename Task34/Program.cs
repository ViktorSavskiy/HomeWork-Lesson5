Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine(string.Join(",", array));
int c = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i]%2 == 0)
   {
    c++;
   } 
}
Console.WriteLine("Количество четных элементов в массиве = " + c);