// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(-9, 10);
//     }
//     return array;
// }

// int[] array = FillArray(12);



// int sumOfPlus = 0;
// int sumOfMinus = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
//     if(array[i] < 0)
//     {
//         sumOfMinus = sumOfMinus + array[i];
//     }
//     else
//     {
//         sumOfPlus = sumOfPlus + array[i];
//     }
// }

// Console.WriteLine();
// Console.WriteLine("Сумма всех отрицательных чисел в массиве составила " + sumOfMinus);
// Console.WriteLine("Сумма всех положительных чисел в массиве составила " + sumOfPlus);

// Задача №2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(-9, 10);
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

// Console.WriteLine("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] arr = FillArray(size);
// PrintArray(arr);

// for(int i = 0; i < arr.Length; i++)
// {
//     arr[i] = arr[i] * (-1);
// }

// PrintArray(arr);

// Задача №3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(-9, 10);
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

// bool Contains(int[] array, int number)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number)
//         {
//             return true;
//         }
//     }

//     return false;
// }

// Console.WriteLine("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] arr = FillArray(size);

// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine());

// PrintArray(arr);

// if(Contains(arr, num))
// {
//     Console.WriteLine("Это число содержится в массиве");
// }
// else
// {
//     Console.WriteLine("Это число не содержится в массиве");
// }

// Задача №4. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке 
// [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(0, 1000);
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

// int size = 123;
// int[] arr = FillArray(size);

// PrintArray(arr);

// int count = 0;

// for(int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] >= 10 && arr[i] <= 99)
//     {
//         count = count + 1;
//     }
// }

// Console.WriteLine("В массиве содержится " + count + " чисел в диапазоне [10,99]");

// Задача №5. На вход подается два массива, отсортированных по возрастанию. Нужно их объелинить, чтобы объединенный массив был также 
// отсортирован по возрастанию.
// [1,3,5,7]
// [2,4,6,8]
// -> [1,2,3,4,5,6,7,8]

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array1 = {2,4,6,8};
int[] array2 = {1,3,5,7};

int[] result = new int[array1.Length + array2.Length];

int i = 0;
int j = 0;
int k = 0;

while(i < result.Length)
{
    if(array1[j] < array2[k] && j < array1.Length || k > array2.Length)
    {
        result[i] = array1[j];
        j++;
    }
    else
    {
        result[i] = array2[k];
        k++;
    }
     i++;
}


PrintArray(result);