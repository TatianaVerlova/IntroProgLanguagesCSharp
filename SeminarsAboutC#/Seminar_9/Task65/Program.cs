// Задача 65: Задайте значения M и N. Напишите функцию, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write(Naturalback(n, ""));

string Naturalback(int start, string res)
{
    if(start == 0)
    {
        return res;
    }

    return($"{start} \t {Naturalback(--start, res)}");
}