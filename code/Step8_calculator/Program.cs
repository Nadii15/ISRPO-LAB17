using System;

namespace Step8_calculator
{
    class Program
    {
      
        static double Add(double a, double b)
        {
            return a + b;
        }

    
        static double Subtract(double a, double b)
        {
            return a - b;
        }

     
        static double Multiply(double a, double b)
        {
            return a * b;
        }

      
        static double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== КАЛЬКУЛЯТОР ===\n");
            
           
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
           
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.Write("Ваш выбор (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            double result = 0;
            string operation = "";
            bool validChoice = true;
            
          
            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    operation = "+";
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    operation = "-";
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    operation = "*";
                    break;
                case 4:
                    result = Divide(num1, num2);
                    operation = "/";
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции!");
                    validChoice = false;
                    break;
            }
            
     
            if (validChoice)
            {
                Console.WriteLine($"\nРезультат: {num1} {operation} {num2} = {result}");
            }
            
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}