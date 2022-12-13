/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] array = new int[4, 4];

PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j+=3)
    {
        array [i,j] = (array [0,j] + array [1,j] + array [2,j]) / 
    }


}
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
