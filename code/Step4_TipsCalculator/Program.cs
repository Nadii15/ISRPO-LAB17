Console.WriteLine("Калькулятор чаевых");
Console.Write("Выедите сумму счёта");
double bill = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите пройент чаевых :");
double tipPercent = Convert.ToDouble(Console.ReadLine());
double tipAmout = bill * (tipPercent / 100);
double totalAmount = bill + tipAmout;

Console.WriteLine("Результат");
Console.WriteLine($"Сумма счёта: {bill}");
Console.WriteLine($" Чаевые({tipPercent}%): {tipAmout}");
Console.WriteLine($"Итого к оплате: {totalAmount}");
Console.WriteLine("Спасибо за использование калькулятора");

