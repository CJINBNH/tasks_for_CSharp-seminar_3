// Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).
// int[] point = new int[2];
// int x = 
// int y = 
// int point[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату: x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату: y");
// int y = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if(quarter == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Номер четверти введен неверно");
}