// Двумерный массив из строк:
// string[,] table = new string[2, 5];

// // как нумеруются индексы в двумерном массиве:
// // table[0, 0]  table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// // table[1, 0]  table[1, 1] table[1, 2] table[1, 3] table[1, 4]
// // индекс строки - первое значение, нумерация начинается с 0; индекс столбца - второе значение, нумерация начинается с 0.

// // String.Empty - константа для инициализации строки, т.е. строки инициализируются как пустые


// table[1, 2] = "слово"; // обращение к элементу такого массива.

// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// Двумерный массив из чисел:

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10); // [1; 10)
        }
    }
}


int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);