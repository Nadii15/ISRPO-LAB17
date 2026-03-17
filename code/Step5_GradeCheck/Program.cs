Console.WriteLine("Определение оценки по баллам");
Console.Write("Введите кол-во бвллов:");
int score = Convert.ToInt32(Console.ReadLine());
string grade;
int numericGrade;
if (score >= 91  && score <= 100)
{
    grade = "Отличник";
    numericGrade = 5;
}
else if (score >= 71 && score < 90)
{
    grade = "Хорошо";
    numericGrade = 4;
}
else if (score >=51 && score < 70)
{
    grade = "Удовлетворительно";
    numericGrade = 3;
}
else if (score >=0 && score < 50)
{
    grade = "Неудовлетвыорительно";
    numericGrade = 2;
}
else
{
    grade = "Ошибка";
    numericGrade = 0;
    Console.WriteLine("Ошибка: баллы должны быть от 0 до 100");
    return;
}
Console.WriteLine("Результат");
Console.WriteLine($"баллы:{score}");
Console.WriteLine($"Оценка: {grade}({numericGrade})");
