/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


int[,] array = new int[3, 4];

int number;
Console.Write($"Введите число = ");
int.TryParse(Console.ReadLine()!, out number);
PrintArray(array);
Console.WriteLine();


bool findNumber = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (number == array[i, j])
        {
            findNumber = true;
            break;
        }
    }
}

if (findNumber)
{
    Console.WriteLine($"Число {number} в массиве есть");
}
else
{
    Console.WriteLine($"Такого числа {number} нет в массиве");
}




void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
