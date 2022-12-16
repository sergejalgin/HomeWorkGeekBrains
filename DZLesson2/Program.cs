/*Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m, n;
Console.Write($"Введите число m = ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите число n = ");
int.TryParse(Console.ReadLine()!, out n);

Console.WriteLine($"{A(m, n)}");

int A(int m, int n)
{
    while (m != 0)
    {
        if (n == 0)
            n = 1;
        else
            n = A(m, n - 1);
        m -= 1;
    }
    return n + 1;
}