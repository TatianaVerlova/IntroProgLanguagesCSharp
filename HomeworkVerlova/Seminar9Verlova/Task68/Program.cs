// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите два числа через пробел: ");
string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int res = AckermannFunction(a, b);

Console.WriteLine("A(" + a + ", " + b + ") = " + AckermannFunction(a, b));


int AckermannFunction(int m, int n)
{
    if(m == 0)
    {
        n++;
        return n;
    }
    
    if(m > 0 && n == 0)
    {
        m--;
        n = 1;
        return AckermannFunction(m, n);
    }
    
    n--;
    n = AckermannFunction(m, n);
    m--;
    return AckermannFunction(m, n);
}