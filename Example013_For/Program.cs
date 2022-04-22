//for(int i=0;i<10;i++)
//{
    //Console.Write(i);
//}

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);

//Таблица умножения

for (int i = 2; i<=10; i++)
{
    for (int j= 2;j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();//разрыв
}

//Работа с текстом.
//Дан текст. В тексте нужно все пробелы разделить черточками
//маленькие буквы "к" заменить большими "К"
//а большие "С" заменить на маленькие "с"

string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо вашего милого Винценгероде,"
            + "вы бы взяли приступом согласие проусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             0123
// s[3] == r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i< length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);