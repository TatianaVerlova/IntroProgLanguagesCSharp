// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа через пробел: ");
string[] input = Console.ReadLine().Split();
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);
int sum = 0;
Console.WriteLine("Сумма натуральных элементов в промежутке от " + m + " до " + n + " составляет: " + PrintSum(m, n, sum));

int PrintSum(int a, int b, int sum)
{
    if(a > b)
    {
        return sum;
    }

    sum += a;
    
    return PrintSum(++a, b, sum);
}