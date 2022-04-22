//Void методы (1и 2):
//1. Ничего не принимает и не возвращает
//2. Что-то принимает, но ничего не возвращает
//3. Ничего не принимает, но что-то возвращает
//4. Что-то принимают и что-то возвращают.

//Метод 1.

void Method1()
{
    Console.WriteLine("Автор Добрый Ээх.");
}

Method1();  //вызов метода (скобки обязтельны)

//Метод 2.
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения"); //именованый аргумент

//Метод 2.1

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

Method21("Текст сообщения", 4); //не именованные аргументы
Method21(count: 4, msg: "Новый текст"); //именованные аргументы в любом порядке

//Метод 3.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Метод 4.

string Method4(int count, string text)
{
    int i = 0;
    string result =String.Empty;
        while(i<count)
        {
            result = result +text;
            i++;
        }
    return result;
}

string res = Method4(10, "Текст");
Console.WriteLine(res);