/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M, N;
Console.Write($"Введите число M = ");
int.TryParse(Console.ReadLine()!, out M);
Console.Write($"Введите число N = ");
int.TryParse(Console.ReadLine()!, out N);

Console.WriteLine($"{NumberSum(M, N)}");

int NumberSum(int left, int right)
{
    if (left >= right)
        return left;
    return left + NumberSum(left + 1, right);
}
