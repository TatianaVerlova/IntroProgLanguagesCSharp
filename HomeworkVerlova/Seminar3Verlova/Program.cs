// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int numberInput = int.Parse(Console.ReadLine());
// int[] numberArray = NumberToArray(numberInput);

// if(numberArray.Length != 5)
// {
//     Console.WriteLine("Это не пятизначное число!");
// }
// else if(PolyndromOfFive(numberArray))
// {
//     Console.WriteLine("Это полиндром");
// }
// else
// {
//     Console.WriteLine("Это не полиндром");
// }

// int[] NumberToArray(int number)
// {
//     int count = 0;
//     int num = number;
//     while(num != 0)
//     {
//         num = num / 10;
//         count++;
//     }

//     int[] numberArray = new int[count];
//     for(int i = 0; i < numberArray.Length; i++)
//     {
//         numberArray[i] = number % 10;
//         number = number / 10;
//     }
//     return numberArray;
// }

// bool PolyndromOfFive(int[] array)
// {
//     for(int i = 0, j = array.Length - 1; i != j; i++, j--)
//     {
//         if(array[i] != array[j])
//         {
//             return false;
//         }
//     }
//     return true;
// }



// *****************************************************************************************************************************

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите координату X1: ");
// int x1Input = int.Parse(Console.ReadLine());

// Console.Write("Введите координату Y1: ");
// int y1Input = int.Parse(Console.ReadLine());

// Console.Write("Введите координату Z1: ");
// int z1Input = int.Parse(Console.ReadLine());

// Console.Write("Введите координату X2: ");
// int x2Input = int.Parse(Console.ReadLine());

// Console.Write("Введите координату Y2: ");
// int y2Input = int.Parse(Console.ReadLine());

// Console.Write("Введите координату Z2: ");
// int z2Input = int.Parse(Console.ReadLine());

// int[] poit1 = new int[] { x1Input, y1Input, z1Input };
// int[] poit2 = new int[] { x2Input, y2Input, z2Input };

// Console.WriteLine("Расстояние между точками составляет "+ Math.Round(GetLength(poit1, poit2), 2));

// double GetLength(int[] coordPoint1, int[] coordPoint2)
// {
//     double sumOfCubes = 0;
//     for(int i = 0; i < coordPoint1.Length; i++)
//     {
//         sumOfCubes = sumOfCubes + Math.Pow((coordPoint2[i] - coordPoint1[i]), 2);
//     }
//     double length = Math.Sqrt(sumOfCubes);
//     return length;
// }



// *****************************************************************************************************************************

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int i = 1;

// while (i <= num)
// {
//     if (i < num)
//     {
//         Console.Write(i*i*i + ", ");
//     }
//     else
//     {
//         Console.Write(i*i*i);
//     }
//     i++;
// }



// *****************************************************************************************************************************

// Дополнительное задание. Напишите программу для вычисления площади круга, прямоугольника и треугольника. Ввод данных осуществляется 
// в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. На втором шаге пользователь
// вводит параметры, необходимые для рассчета. Затем, выводится результат.

// double GetCircleSquare(double r)
// {
//     double pi = 3.14;
//     double circleSquare = pi * r * r;
//     return circleSquare;
// }

// double GetRectangleSquare(double a, double b)
// {
//     double RectangleSquare = a * b;
//     return RectangleSquare;
// }

// double GetTriangleSquare(double a, double h)
// {
//     double TriangleSquare = 1/2 * a * h;
//     return TriangleSquare;
// }

// Console.Write("Площадь какой фигуры нужно вычислить? Введите: круг, прямоугольник или треугольник ");
// string figure = Console.ReadLine();

// if (figure == "круг")
// {
//     Console.Write("Введиде радиус окружности: ");
//     double rInput = double.Parse(Console.ReadLine());

//     Console.Write("Площадь окружности равна " + GetCircleSquare(rInput));
// }
// else if (figure == "прямоугольник")
// {
//     Console.Write("Введиде длину стороны a: ");
//     double aInput = double.Parse(Console.ReadLine());

//     Console.Write("Введиде длину стороны b: ");
//     double bInput = double.Parse(Console.ReadLine());

//     Console.Write("Площадь прямоугольника равна " + GetRectangleSquare(aInput, bInput));
// }
// else if (figure == "треугольник")
// {
//     Console.Write("Введиде длину основания треугольника: ");
//     double aInput = double.Parse(Console.ReadLine());

//     Console.Write("Введиде длину высоты треугольника: ");
//     double hInput = double.Parse(Console.ReadLine());

//     Console.Write("Площадь прямоугольника равна " + GetRectangleSquare(aInput, hInput));
// }
// else
// {
//     Console.Write("Я не знаю, как вычислить площадь этой фигуры");
// }