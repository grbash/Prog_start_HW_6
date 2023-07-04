// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 41: Пользователь вводит с клавиатуры несколько чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Task 41:");
Console.WriteLine();

int CountOfNegativeNumbers(string massage)
{
    Console.Write(massage);
    string? num = Console.ReadLine();

    int cur = 0;
    int counter = 0;

    while (num != "a")
    {
        cur = Convert.ToInt32(num);
        if (cur > 0) counter++;
        num = Console.ReadLine();
    }
    
    return counter;
}

int res = CountOfNegativeNumbers("Enter numbers, to complete enter 'a' : ");
Console.WriteLine($"Number of numbers greater than 0 - {res}");