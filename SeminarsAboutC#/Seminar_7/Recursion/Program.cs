// Найти факториал числа

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Факториал этого числа = " + Factorial(num));

int Factorial(int number)
{
    if(number == 1)
    {
        return number;
    }

    return number * Factorial(number -1);
}