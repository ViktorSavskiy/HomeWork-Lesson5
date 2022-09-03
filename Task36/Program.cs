
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
}
Console.WriteLine(string.Join(", ", array));
int numSum = 0;
for (int i = 0; i < array.Length; i++)
{
   if (i%2 == 1)
   {
    numSum += array[i];
   } 
}
Console.WriteLine("Сумма элементов на нечетных позициях " + numSum);