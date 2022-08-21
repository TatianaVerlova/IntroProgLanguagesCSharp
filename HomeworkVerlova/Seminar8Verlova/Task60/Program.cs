// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


Console.WriteLine("Введите количество элементов массива по всем трем осям через пробел: ");
string[] input = Console.ReadLine().Split();
int xLength = int.Parse(input[0]);
int yLength = int.Parse(input[1]);
int zLength = int.Parse(input[2]);
int[,,] array = new int[xLength, yLength, zLength];
int number = 10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i,j,k] = number;
            number++;
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write(array[i,j,k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}