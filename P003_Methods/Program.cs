// Условные виды методов:
// Вид 1
void Method1()
{
    Console.WriteLine("Автор Таня В.");
}

// Как вызываются такие методы:

Method1();

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // Увеличение счетчика на 1 называется ИНКРЕМЕНТ, а уменьшение - ТЕГКРИМЕНТ
    }
}
Method21("Текст", 4); // или
Method21(count: 4, msg: "Текст"); // Явно указали, какому аргументу какое значение мы хотим передать, в этом случае их необязательно писать по порядку

// Вид 3

int Method3() // Обязательно указываем, какой тип данных будет у того, что выведет данная функция
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);