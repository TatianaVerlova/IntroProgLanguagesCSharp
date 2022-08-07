// Выводим таблицу умножения

for (int i = 1; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}"); // Интерполяция строк
    }
    Console.WriteLine(); // переход на новую строку
}