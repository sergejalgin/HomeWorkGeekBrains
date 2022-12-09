/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);

PrintArray(array);
Console.WriteLine();

int sum = 0;
for (int j = 1; j < array.Length; j += 2)
{
    sum = sum + array[j];
}
Console.WriteLine($"Сумма = {sum}");


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
