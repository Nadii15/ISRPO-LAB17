using System;

namespace Task2_IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Проверка числа на простоту ");

           
            Console.Write("Введите число для проверки: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: введено некорректное число!");
                return;
            }

            
            bool isPrime = IsPrime(number);
            
            if (isPrime)
            {
                Console.WriteLine($"\nЧисло {number} - ПРОСТОЕ ✓");
            }
            else
            {
                Console.WriteLine($"\nЧисло {number} - НЕ простое ✗");
            }
        }


        static bool IsPrime(int n)
        {
          
            if (n <= 1)
            {
                return false;
            }

 
            int i = 2;
            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    return false; 
                }
                i = i + 1;
            }

            return true; 
        }
    }
}