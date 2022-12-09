/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);

PrintArray(array);
Console.WriteLine();



void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
