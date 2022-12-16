/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int N;
Console.Write($"Введите число N = ");
int.TryParse(Console.ReadLine()!, out N);

Console.WriteLine($"{Number(N, 1)}");

string Number(int left, int right)
{
    if (left <= right)
        return right.ToString();
    return $"{left} {Number(left - 1, right)}";
}
