// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array1 = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};


int[,] array2 = {
    { 1, 5, 8, 5 },
    { 4, 9, 4, 2 },
    { 7, 2, 2, 6 },
    { 2, 3, 4, 7 }
};

if(array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Это не согласованные матрицы!");
    return;
}

int[,] arrayMultiply = new int[array1.GetLength(0),array2.GetLength(1)];

for (int i = 0; i < arrayMultiply.GetLength(0); i++)
{
    for (int j = 0; j < arrayMultiply.GetLength(1); j++)
    {
        int sum = 0;
        for (int t = 0; t < array1.GetLength(1); t++)
        {
            sum = sum + array1[i,t] * array2[t,j];
        }
        arrayMultiply[i,j] = sum;
    }
}

PrintMatrix(arrayMultiply);