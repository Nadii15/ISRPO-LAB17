Console.WriteLine("Выбор одежды");
Console.Write("Введите текущую температуру:");
int temperatyre = Convert.ToInt32(Console.ReadLine());
if (temperatyre >= 20)
{
    Console.WriteLine("Наденьте платье");
}
else
{
    Console.WriteLine("не Надевайте платье ");
}
Console.WriteLine("Хорошего дня!");