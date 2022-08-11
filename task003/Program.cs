// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите число x1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число у1: ");
double У1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число у2: ");
double У2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt((X2-X1)*(X2-X1)+(У2-У1)*(У2-У1));
Console.WriteLine(length);

// второе решение

double length = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2));