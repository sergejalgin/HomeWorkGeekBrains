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
int[,] array = new int[2, 2]; // Размер 1 массива
int[,] array2 = new int[3, 3]; // Размер 2 массива

PrintArrayRandom(array); // Генерация чисел 1 массива
PrintArrayRandom(array2); // Генерация чисел 2 массива
PrintArray(array); // Вывод рандомного 1 массива
Console.Write($"|");
PrintArray(array2); // Вывод рандомного 2 массива
Console.WriteLine();

MethodSumArray(array);
MethodSumArray(array2);



Console.WriteLine($"{MethodSumArray(array)} + {MethodSumArray(array2)} = {MethodSumArray(array) + MethodSumArray(array2)}");

// Функция суммы элементов массива
int MethodSumArray(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
    }
    return (sum);
}





//Функция заполнения массива рандомными числами
void PrintArrayRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            array[i, j] = new Random().Next(10);
        }
        Console.WriteLine();
    }
}

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