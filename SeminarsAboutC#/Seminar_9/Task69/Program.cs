// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите два числа через пробел: ");
string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

Console.WriteLine(Power(a, b));

double Power(int n, int p)
{
    if (p == 1)
    {
        return n;
    }
    if (p == 0)
    {
        return 1;
    }
    if (p < 0)
    {
        return 1 / Power(n, p * (-1));
    }

    return n * Power(n, --p);
}