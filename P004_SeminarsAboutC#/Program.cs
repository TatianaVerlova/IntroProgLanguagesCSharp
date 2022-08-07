// // Задача №1. Напишите программу, которая на вход принимает число и выдает его квадрат.
// Console.Write("Введите число ");
// int number = int.Parse(Console.ReadLine()); // Преобразовали строку в число
// int result = number * number;
// Console.Write("Result: " + result);

// Задача №2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.Write("Введите число в квадрате ");
// int numberA = int.Parse(Console.ReadLine()); // Преобразовали строку в число
// Console.Write("Введите числовозводимое в квадрат ");
// int numberB = int.Parse(Console.ReadLine()); // Преобразовали строку в число
// int result = numberB * numberB;
// if (result == numberA)
// {
//     Console.Write("yes");
// }
// else
// {
//     Console.Write("no");
// }
/*
Задача №3. Напишите программу, которая будет выдавать названия для недели по заданному номеру.
*/
// Console.Write("Введите номер дня недели ");
// int number = int.Parse(Console.ReadLine()); // Преобразовали строку в число

// if (number == 1)
// {
//     Console.Write("Понедельник");
// }
// else if (number == 2)
// {
//     Console.Write("Вторник");
// }
// else if (number == 3)
// {
//     Console.Write("Среда");
// }
// else if (number == 4)
// {
//     Console.Write("Четверг");
// }
// else if (number == 5)
// {
//     Console.Write("Пятница");
// }
// else if (number == 6)
// {
//     Console.Write("Суббота");
// }
// else if (number == 7)
// {
//     Console.Write("Воскресенье");
// }

// Задача №4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Введите число ");
// int num = int.Parse(Console.ReadLine());
// int i = -num;

// while (i <= num)
// {
//     Console.Write(i + " ");
//     i++;
// }

// Решение с циклом for:

// Console.Write("Введите число ");
// int num = int.Parse(Console.ReadLine());

// for (int i = -num; i <= num; i++)
// {
//     Console.Write(i + " ");
// }

// Задача №5. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
int last = num % 10;
Console.Write(last);