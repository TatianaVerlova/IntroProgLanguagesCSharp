// Задача 65: Задайте значение N. Напишите функцию, которая выведет все натуральные числа в промежутке от N до 0.

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