void FillArray(int[] collection) // Создаем новый метод с именем FillArray, 
//наполняющий миссив int[] collection числами
{
    int length = collection.Length; //вычисляем длину массива collection
    int index = 0;//позиция первого числа массива
    while(index < length) //пока index меньше длины массива
    {
        collection[index] = new Random().Next(1, 10);//создаем новое случайное число
        //от 1 до 10 в массиве collection
        index++;// index увеличивается на 1
    }
}

void PrintArray(int[] col) // Создаем новый метод с именем PrintArray, 
//отобаражающий на экране миссив int[] col
{
    int count = col.Length;//вычисляем длину массива col
    int position = 0;//позиция первого числа массива
    while (position < count)//пока position меньше длины массива
    {
        Console.Write($"{col[position]} ");//выводим на экран число на позиции position
        // из массива col
        position++;//position увеличивается на 1
    }
}

int IndexOf(int[] collection, int find)//метод поиска индекса заданного числа find
//в заданном массиве collection
{
    int count = collection.Length;//длина массива
    int index = 0;//позиция в массиве
    int position =-1;//позиция искомого числа. Если числа в массиве нет - выдаст -1

    while(index < count)//пока позиция меньше длины
    {
        if(collection[index] == find)//если числов в позиции index равно искомому 
        {
            position = index;//позиция искомого числа равна index
            break;//окончание цикла
        }
        index++;//следующая позиция
    }
    return position;//вернуть результат: позиция искомого числа
}

int[] array = new int[10]; // Создай новый массив из 10 элементов

FillArray(array);//использует метод генерации элементов для массива array
PrintArray(array);//использует метод для вывода на эктан массива array
Console.WriteLine();//пустая строка

int pos = IndexOf(array, 4);//найти позицию числа (второй аргумент) 
//в массиве array с помощью метода
Console.WriteLine(pos);//вывести на экан позицию.

