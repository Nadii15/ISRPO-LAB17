// See https://aka.ms/new-console-template for more information
Console.WriteLine("Таблица умножения");
Console.Write("Введите число для таблицы умножения");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица умножения для {number}");
for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}
Console.WriteLine("Конец программы");