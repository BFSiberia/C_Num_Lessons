// Число n в степени n с применением свойства степени (степень пополам, база сама на себя)

// int PowerRecMath (int a, int b)
// {
//     if (b==0) return 1;
//     else if (b%2==0) return PowerRecMath(a*a,b/2); //если степень кратна 2, 
//     else return PowerRecMath(a*a,b/2)*a;
// }

// Console.WriteLine(PowerRecMath(2,9));

// Все варианты слов из алфавит, заданной длины

// int n =1; // счетчик слов
// void FindWords(string abc, char[] word, int length = 0) // алфавит, массив для слов, длина слова
// {
//     if (length == word.Length) //условие заверешния рекурсии: если счетчик длины слова = длине массива word
//     {
//         Console.WriteLine($"{n++} {new String(word)}");// счетчик слова + новое слово
//         return;
//     }
//     for (int i=0; i<abc.Length;i++)
//     {
//         word[length] = abc[i];
//         FindWords(abc,word,length+1);
//     }
// }

// FindWords("абвг", new char[3]);

// Пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}

Towers();