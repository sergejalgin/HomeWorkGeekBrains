/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[1];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);

PrintArray(array);


// 
// {
//     int even = array[i] % 2 == 0 ? 0 : 1;
//     Console.Write($"Количество четных чисел = {even}");
// }
// Console.Write($"Нет четных чисел"); 
// }



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        Console.WriteLine();
    }
}
