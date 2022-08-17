// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// 1 2 3 4    3 4 5 6
// 5 6 7 8 -> 5 6 7 8
// 9 0 1 2    9 0 1 2
// 3 4 5 6    1 2 3 4

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void Swap(int[,] array, int i, int j)
{
    int temp = array[i, j];
    array[i, j] = array[array.GetLength(0) - 1, j];
    array[array.GetLength(0) - 1, j] = temp;
}

int[,] myArray = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 0, 1, 2 },
    { 3, 4, 5, 6 }
};

for(int i = 0; i < myArray.GetLength(1); i++)
{
    Swap(myArray, 0, i);
}

PrintArray(myArray);