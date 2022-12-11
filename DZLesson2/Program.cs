/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);

PrintArray(array);


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count += 1;
}

Console.WriteLine($"Количество четных чисел = {count}");



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        Console.WriteLine();
    }
}
