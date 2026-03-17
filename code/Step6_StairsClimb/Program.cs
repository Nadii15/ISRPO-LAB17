Console.WriteLine("Подъём по лестнице");
Console.Write("На какой этаж нужно подняться?");
int targetFloor = Convert.ToInt32(Console.ReadLine());
int currentFloor = 1;
Console.Write("Начинаем подъём");
while(currentFloor<targetFloor)
{
    currentFloor++; 
    Console.WriteLine($"Поднялись на {currentFloor} этаж");
}
Console.WriteLine($"Вы достигли {targetFloor} этажа");
Console.WriteLine("Конец программы");
