/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] array = new int[3, 3]; // Размер массива
PrintArrayRandom(array);
PrintArray(array); // Вывод рандомного массива
Console.WriteLine();


int minLineSum = 0;
int sum = 0;
int minLine = 0;

// Сумма первой строки
for (int i = 0; i < array.GetLength(0); i++)
{
    minLineSum += array[0, i];
}

// Сравнение суммы первой строки с другими и поиск строки с наименьшей суммой
for (int i = 1; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < minLineSum)
    {
        minLineSum = sum;
        minLine = i;
    }
    sum = 0;
}
Console.WriteLine($"{minLine + 1} строка");



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