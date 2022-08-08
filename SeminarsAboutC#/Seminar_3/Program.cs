// Задача №1: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.

// Console.Write("Введите координату X: ");
// int xInput = int.Parse(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// int yInput = int.Parse(Console.ReadLine());

// int result = getQuater(xInput, yInput);
// Console.WriteLine("Точка находится в " + result + " четверти");

// int getQuater(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     else if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//         else if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//         else if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     return 0;
// }

// Задача №2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти 
// (x и y).

// Console.WriteLine ("Введите номер четверти: ");
// int num = int.Parse(Console.ReadLine());

// string result = XY (num);

// Console.WriteLine("Ответ: " + result);

// string XY (int quater)
// {
//     if (quater == 1)
//     {
//         return "x > o & y > 0";
//     }
//     else if (quater == 2)
//     {
//         return "x < o & y > 0";
//     }
//     else if (quater == 3)
//     {
//         return "x < o & y < 0";
//     }
//     else if (quater == 4)
//     {
//         return "x > o & y < 0";
//     }
//     else
//     {
//         return "нет такой четверти";
//     }
// }

// Задача №3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату X1: ");
int x1Input = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y1: ");
int y1Input = int.Parse(Console.ReadLine());

Console.Write("Введите координату X2: ");
int x2Input = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y2: ");
int y2Input = int.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками составляет "+ Math.Floor(GetLength(x1Input, y1Input, x2Input, y2Input))); // Math.Floor() - 
//округлить до целого
// Math.Round(GetLength(x1Input, y1Input, x2Input, y2Input), 2) - округлить до 2х знаков после запятой

double GetLength(int x1, int y1, int x2, int y2)
{
    double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)); // Квадратный корень Math.Sqrt()
    return length;
}