// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
PrintNum(1, n);

void PrintNum(int start, int end)
{
    if(start > end)
    {
        return;
    }

    Console.Write(start + "\t");
    start++;
    PrintNum(start, end);
}