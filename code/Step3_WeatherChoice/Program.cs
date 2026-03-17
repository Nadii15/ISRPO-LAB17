// Начало
Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру:");
int temperatyre = Convert.ToInt32(Console.ReadLine());
if (temperatyre >= 20)
{
    Console.WriteLine("Наденьте лёгкую одежду");
}
else
{
    Console.WriteLine("Наденьте тёплую одежду");
}
Console.WriteLine("Хорошего дня!");
