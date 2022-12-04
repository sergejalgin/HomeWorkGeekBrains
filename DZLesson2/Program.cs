/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int a = index;
int index = 4;

Console.Write($"Ввведите число = ");
int.TryParse(Console.ReadLine()!, out a);

if (array[index] <= a)
{
    Console.WriteLine($"Нет");
}
else
    Console.WriteLine($"Да");





