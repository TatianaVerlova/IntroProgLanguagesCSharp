// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
int[,] FillSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int number = 1;
    int start = 0;
    int end = array.GetLength(0);
    int i = 0;
    int j = 0;

    while (end - start > 0)
    {
        while (j < end)
        {
            array[i, j] = number;
            number++;
            j++;
        }
        i++;
        j--;
        while (i < end)
        {
            array[i, j] = number;
            number++;
            i++;
        }
        i--;
        j--;
        end--;
        while (j >= start)
        {
            array[i, j] = number;
            number++;
            j--;
        }
        i--;
        j++;
        start++;
        while (i >= start)
        {
            array[i, j] = number;
            number++;
            i--;
        }
        i++;
        j++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] array = FillSpiralArray(row, col);
PrintArray(array);