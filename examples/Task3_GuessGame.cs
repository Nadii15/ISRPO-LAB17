using System;

namespace Task3_GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра 'Угадай число' ");
            
            bool playAgain = true;
            
            while (playAgain)
            {
                PlayGame();
                
                Console.WriteLine("Хотите сыграть снова? (да/нет): ");
                string? answer = Console.ReadLine()?.ToLower();
                playAgain = (answer == "да" || answer == "д" || answer == "yes" || answer == "y");
                Console.WriteLine();
            }
            
            Console.WriteLine("Спасибо за игру! До свидания!");
        }

        static void PlayGame()
        {
            
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            int userGuess = 0;
            bool guessed = false;

            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

           
            while (!guessed)
            {
                Console.Write("Ваша попытка: ");
                string? input = Console.ReadLine();

                
                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine(" Ошибка: введите корректное число!");
                    continue;
                }

                
                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Ошибка: число должно быть от 1 до 100!\n");
                    continue;
                }

                attempts++;

                
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($" Поздравляю! Вы угадали число {secretNumber}!");
                    Console.WriteLine($" Статистика: {attempts} попыток");
                    PrintRating(attempts);
                    guessed = true;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine(" Больше!");
                }
                else
                {
                    Console.WriteLine(" Меньше!");
                }
            }
        }

       
        static void PrintRating(int attempts)
        {
            Console.Write(" Ваш рейтинг: ");
            if (attempts <= 5)
                Console.WriteLine("Отлично! Вы настоящий мастер!");
            else if (attempts <= 10)
                Console.WriteLine("Хорошо! Неплохой результат!");
            else if (attempts <= 15)
                Console.WriteLine("Нормально! Можно лучше!");
            else
                Console.WriteLine("Попробуйте ещё раз! Уверен, получится лучше!");
        }
    }
}
