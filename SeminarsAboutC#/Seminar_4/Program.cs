// Задача №1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());

// int sum = 0;


// for (int i = 1; i <= a; i++)
// {
//     sum = sum + i;
// }

// Console.WriteLine(sum);

// Задача №2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Решение 1:

// Console.WriteLine("Введите число: ");
// string num = Console.ReadLine();
// int length = num.Length;
// Console.WriteLine("Количество цифр равно " + length);

// Решение 2:

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int count = 0;

// while (num > 0)
// {
//     num = num / 10;
//     count++;
// }
// Console.WriteLine(count);

// Задача №3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("Произведение всех чисел от 1 до " + num + " равно " + Multiply(num));

// int Multiply(int n)
// {
//     int res = 1;

//     for (int i = 1; i <= n; i++)
//     {
//         res = res * i;
//     }

//     return res;
// }

// Задача №4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

Console.WriteLine("Ввкдите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] Arr = FillArray(size);

for(int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + " ");
}