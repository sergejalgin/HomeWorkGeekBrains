/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int M = 1;

List<int> array = new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Введите число = ");
    int.TryParse(Console.ReadLine()!, out M);
    if (M != 0)
        array.Add(M);
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Count; i++)
{
    if (array[i] > 0)
        count += 1;
}
Console.WriteLine($"Количество чисел больше 0 = {count}");




