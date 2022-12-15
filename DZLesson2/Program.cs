/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] array = new int[2, 2] { { 2, 4 }, { 3, 2 } }; // 1 массив
int[,] array2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };// 2 массив
int[,] arrayResult = new int[2, 2];

PrintArray(array); // Вывод 1 массива
Console.WriteLine();
PrintArray(array2); // Вывод 2 массива
Console.WriteLine();




// Результирующая матрица
if (array.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine(" Выполнить не возможно ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        arrayResult[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            arrayResult[i, j] += array[i, k] * array2[k, j];
        }
    }
}
PrintArray(arrayResult); // Вывод результирующей матрицы


// Функция вывода двумерного массива
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}