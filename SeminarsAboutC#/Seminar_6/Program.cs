// Задача №1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый -
// на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

// Console.WriteLine("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] arr = FillArray(size);
// PrintArray(arr);
// Console.WriteLine();

// int tmp = 0;

// for(int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
// {
//     tmp = arr[i];
//     arr[i] = arr[j];
//     arr[j] = tmp;
// }

// PrintArray(arr);

// Задача №2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
// такой длины. Помни! Сумма двух сторон всегда должна быть больше третьей стороны!

// Console.WriteLine("Введите 1 число: ");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите 2 число: ");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите 3 число: ");
// int c = int.Parse(Console.ReadLine());

// bool IsTriangle(int a, int b, int c)
// {
//     if(a + b > c && b + c > a && a + c > b)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// if(IsTriangle(a, b, c))
// {
//     Console.WriteLine("Треугольник со сторонами такой длины возможен");
// }
// else
// {
//     Console.WriteLine("Треугольник со сторонами такой длины НЕ возможен");
// }

// Задача №3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] array = { 1, 2, 3, 4, 5 };
// int[] copyArrya = GetCopy(array);
// System.Console.WriteLine("\n Копия исходного массива создана : {0} ", String.Join(" ", GetCopy(array)));
// System.Console.WriteLine();


// int[] GetCopy(int[] array)
// {
//     int[] copy = new int[array.Length];

//     for(int i = 0; i < copy.Length; i++)
//     {
//         copy[i] = array[i];
//     }
// }


// Задача №4. Напишите программу, которая последовательно выводит числа от 1 до 100, но если число делится на 3 заменяет его на Fizz,
// если делится на 5 заменяет его на Buzz, а если и 3 и 5 на FizzBuzz.

// for(int i = 1; i <= 100; i++)
// {
//     if(i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if(i % 3 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else if(i % 5 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }

// Задача №5. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] res = new int[32];
int i = 0;
while(num > 0)
{
    res[i] = num % 2;
    num = num / 2;
    i++;
}

for(int j = i - 1; j >= 0; j--)
{
    Console.Write(res[j]);
}
