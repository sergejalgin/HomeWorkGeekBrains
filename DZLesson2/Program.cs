﻿/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
int N;
Console.Write($"Ввведите число = ");
int.TryParse(Console.ReadLine()!, out N);
double sum = 0;
while (N > 0)
{
    sum = sum + N % 10;
    N = N / 10;

}
Console.WriteLine($"-> {sum}");