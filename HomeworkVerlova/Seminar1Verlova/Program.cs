﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
//
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// if (numberA > numberB)
// {
//     Console.Write("max = " + numberA);
// }
// else
// {
//     Console.Write("max = " + numberB);
// }

// **************************************************************************************************************

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int numberC = int.Parse(Console.ReadLine());

// int max = numberA;

// if (numberB > max)
// {
//     max = numberB;
// }

// if (numberC > max)
// {
//     max = numberC;
// }

// Console.Write("max = " + max);

// **************************************************************************************************************

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.Write("да");
// }
// else
// {
//     Console.Write("нет");
// }

// **************************************************************************************************************

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 1;

while (i <= num)
{
    if (i % 2 == 0)
    {
        if (i < num)
        {
            Console.Write(i + ", ");
        }
        else
        {
            Console.Write(i);
        }
    }

    i++;
}