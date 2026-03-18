using System;

namespace Task1_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Калькулятор ИМТ ");

        
            Console.Write("Введите ваш вес (кг): ");
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
            {
                Console.WriteLine("Ошибка: некорректное значение веса!");
                return;
            }

            Console.Write("Введите ваш рост (м): ");
            if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
            {
                Console.WriteLine("Ошибка: некорректное значение роста!");
                return;
            }

            double bmi = weight / (height * height);
            Console.WriteLine($"\nВаш ИМТ: {bmi:F1}");

            // Определение категории и рекомендации
            string category = GetBMICategory(bmi);
            string recommendation = GetRecommendation(bmi);

            Console.WriteLine($"Категория: {category}");
            Console.WriteLine($"Рекомендация: {recommendation}");
        }


        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Недостаточный вес";
            else if (bmi < 25)
                return "Нормальный вес";
            else if (bmi < 30)
                return "Избыточный вес";
            else
                return "Ожирение";
        }

    
        static string GetRecommendation(double bmi)
        {
            if (bmi < 18.5)
                return "Рекомендуется набрать массу: увеличьте калорийность рациона и добавьте силовые тренировки.";
            else if (bmi < 25)
                return "Продолжайте вести здоровый образ жизни: сбалансированное питание и регулярная активность.";
            else if (bmi < 30)
                return "Рекомендуется пересмотреть питание и добавить физическую активность для снижения веса.";
            else
                return "Рекомендуется обратиться к врачу для консультации и разработки плана снижения веса.";
        }
    }
}
