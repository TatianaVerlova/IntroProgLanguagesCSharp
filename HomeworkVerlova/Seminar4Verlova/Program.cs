// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число a: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число b: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("a в степени b составит " + RaiseToPowerOf(num1, num2));

// int RaiseToPowerOf(int a, int b)
// {
//     int res = 1;
//     for(int i = 0; i < b; i++)
//     {
//         res = res * a;
//     }
//     return res;
// }



//********************************************************************************************************************************

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int numInput = int.Parse(Console.ReadLine());
// Console.WriteLine("Сумма цифр в этом числе составляет " + GetSumOfDigits(numInput));

// int GetSumOfDigits(int num)
// {
//     int restOfDivision = num;
//     int length = 0;
//     while(restOfDivision != 0)
//     {
//         restOfDivision = restOfDivision / 10;
//         length++;
//     }

//     int sum = 0;
//     int i = length - 1;
//     while(i > 0)
//     {
//         int multiplier = 1;
//         int j = 0;
//         while(j < i)
//         {
//             multiplier = multiplier * 10;
//             j++;
//         }
//         int digit = num / multiplier;
//         sum = sum + digit;
//         num = num % multiplier;
//         i--;
//     }
//     sum = sum + num;
//     return sum;
// }



//********************************************************************************************************************************

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Укажите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arrayInput = FillArrayByUser(size);
PrintArray(arrayInput);

int[] FillArrayByUser(int arraySize)
{
    int[] array = new int[arraySize];
    for(int i = 0; i < arraySize; i++)
    {
        Console.WriteLine("Введите число: ");
        int element = int.Parse(Console.ReadLine());
        array[i] = element;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        if(i == (count-1))
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write("]");
}