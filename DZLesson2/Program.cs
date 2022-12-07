/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int a, b;

Console.Write($"Введите число А = ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число B = ");
int.TryParse(Console.ReadLine()!, out b);

int f = a;
for (int i = 2; i <= b; i++)
{
    f = f * a;
}
Console.WriteLine($"{f}");