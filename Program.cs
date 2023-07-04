// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

/*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.

    y = k1 * x + b1  ---------->  0 = (k1 - k2)x + (b1 - b2)  ---------->  x = (b2 - b1)/(k1 - k2)  ----------> 
    y = k2 * x + b2

    ---------->  y = k1((b2 - b1)/(k1 - k2)) + b1
*/

Console.WriteLine("Task 43:");
Console.WriteLine();

double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] point = new double[2];

    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * ((b2 - b1) / (k1 - k2)) + b1;

    return point;
}

Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] res = new double[2];
if (k1 != k2)
{
    res = IntersectionPoint(k1, b1, k2, b2);
    Console.WriteLine($"Intersection point is [{res[0]}, {res[1]}]");
}
else
    Console.WriteLine("There is no intersection point");


