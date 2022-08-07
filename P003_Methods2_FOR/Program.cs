string Method4(int count, string text)
{
    string result = String.Empty; // Инициализация пустой строки
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
// Console.WriteLine(res);

// Решение задач

// Задача 1. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// Вспомогательные функции для работы со строками:
// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // Инициализация пустой строки

    int length = text.Length; // Свойство, показывающее количество символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

newText = Replace(newText, 'В', 'в');
// Console.WriteLine(newText);

// Задача 2. Упорядочить массив
//
// Как решать?
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SellectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length -1 ; i++) // (array.Length -1) т.к. в стрю 81 j = i +1
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array [minPosition];
        array [minPosition] = temporary;

    }
}

PrintArray(arr);
SellectionSort(arr);
PrintArray(arr);