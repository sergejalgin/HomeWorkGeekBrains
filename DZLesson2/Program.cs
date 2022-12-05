/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int xa, ya, za, xb, yb, zb;
Console.Write($"Ввведите координаты x точки A = ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Ввведите координаты y точки A = ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Ввведите координаты y точки A = ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write($"Ввведите координаты x точки B = ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Ввведите координаты y точки B = ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"Ввведите координаты y точки B = ");
int.TryParse(Console.ReadLine()!, out zb);

double ans = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));

Console.WriteLine($"Расстояние между точками А и B = {Math.Round(ans, 2)}");
