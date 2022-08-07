// Задача №1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифрц числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int num = new Random().Next(10, 100); // т.к. метод Next принимает аргументы, не включая левый
// Console.WriteLine("Random number: " + num);

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// int getMax(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// Console.WriteLine("Max number is " + getMax(firstDigit, secondDigit));

// Задача №2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// Console.WriteLine("Random number: " + num);

// int getNumberWithotSecondDigit (int number)
// {
//     int firstDigit = number / 100;
//     int thirdDigit = number % 10;
//     int result = firstDigit * 10 + thirdDigit;
//     return (result);
// }

// Console.WriteLine(getNumberWithotSecondDigit(num));

// Задача №3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите первое число ");
// int numberA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число ");
// int numberB = int.Parse(Console.ReadLine());

// if (numberB % numberA == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("не кратно, остаток " + numberB % numberA);
// }

// Задача №4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число ");
// int num = int.Parse(Console.ReadLine());

// void isNumberMultiple(int a)
// {
//     if (a % 7 == 0 && a % 23 == 0)
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }

// isNumberMultiple(num);

// Задача №5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int numB = int.Parse(Console.ReadLine());

void isNumberARoot(int a, int b)
{
    if (a * a == b || b * b == a)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

isNumberARoot(numA, numB);

// bool isSqr(int a, int b)
// {
//     if (a * a == b)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

