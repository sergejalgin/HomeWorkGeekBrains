/*Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int a, b, c;

int max = 0;

Console.Write("Введите первое число = ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите второе число = ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write("Введите третье число = ");
int.TryParse(Console.ReadLine()!, out c);

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
    Console.WriteLine($"Максимальное число = {c}");
}
else
    Console.WriteLine($"Максимальное число = {max}");

