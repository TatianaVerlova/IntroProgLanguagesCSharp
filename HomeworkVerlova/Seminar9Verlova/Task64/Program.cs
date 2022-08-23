// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите два числа через пробел: ");
string[] input = Console.ReadLine().Split();
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);
PrintNum(m, n);

void PrintNum(int a, int b)
{
    if(a > b)
    {
        return;
    }

    Console.Write(a + "\t");
    PrintNum(++a, b);
}