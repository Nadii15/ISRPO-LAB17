int[] array = {5,12,8,23,445,17,9,31};
Console.WriteLine("Поиск максимального элемента");
Console.WriteLine("Массив" + string.Join(",",array));
int max = array[0];
for (int i=1;i<array.Length;i++)
{
  if (array[i] > max)
    {
        max = array[i];
    }  
}
Console.WriteLine($"Максимальный элемент {max}");