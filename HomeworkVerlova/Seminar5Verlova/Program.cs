// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(100, 1000);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Укажите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] arr = FillArray(size);
// PrintArray(arr);

// int count = 0;
// for(int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] % 2 == 0)
//     {
//         count = count + 1;
//     }
// }

// Console.WriteLine("Количество четных чисел в массиве составило " + count);



// ***************************************************************************************************************************************

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(-100, 100);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Укажите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] arr = FillArray(size);
// PrintArray(arr);

// int sum = 0;
// for(int i = 1; i < arr.Length; i = i +2)
// {
//     sum = sum + arr[i];
// }

// Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве составила " + sum);


// ***************************************************************************************************************************************

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] FillArray(int size)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(-100, 100);
//     }

//     return array;
// }

// void PrintArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Укажите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// double[] arr = FillArray(size);
// PrintArray(arr);

// double max = arr[0];
// double min = arr[0];

// for(int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }

// double res = min + max;
// Console.WriteLine("Сумма максимального и минимального элементов массива составляет " + res);



// ***************************************************************************************************************************************

// Дополнительное задание - задача, которую мы не успели решить на вебинаре. Если пойдет сложно, то разберем в начале следующего занятия.
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = FillArray(size);
PrintArray(arr);

int length = 0;

if(arr.Length % 2 == 0)
{
    length = arr.Length / 2;
}
else
{
    length = arr.Length / 2 + 1;
}

int[] arr2 = new int[length];

if(arr.Length % 2 == 0)
{
    for(int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = arr[i] * arr[arr.Length - i - 1];
    }
}
else
{
    for(int i = 0; i < (arr2.Length - 1); i++)
    {
        arr2[i] = arr[i] * arr[arr.Length - i - 1];
    }
    arr2[arr2.Length - 1] = arr[arr.Length / 2];
}

PrintArray(arr2);