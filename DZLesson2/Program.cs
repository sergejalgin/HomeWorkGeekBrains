/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = { 1, 2, 5, 7, 19, 6, 1, 33 };

Console.Write($"-> ");
for (int i = 0; i < array.Length - 3; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.Write($"-> ");
Console.Write($"{array[5]} {array[6]} {array[7]}");
Console.WriteLine();