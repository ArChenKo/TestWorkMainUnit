// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string Parametr(string message) // метод для ввода значений с клавиатуры
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    if (value==string.Empty)
    {
        Console.WriteLine("Пустые строки вводить нельзя!");
        string val = Parametr("Введите значение еще раз:");
        return val;
    }
    return value;
}
string [] FillArray(int sizeArray) // метод заполнения массива значениями
{
    string [] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
        array[i]=Parametr("Введите следующий элемент списка:");
    return array;
}
string [] SelectionArray(string [] array) // метод создания строкового массива с отобранными значениями
{
    string list = string.Empty;
    int count = 0;
    string ch = "/";
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            list += array[i]+ch;
            count++;
        }
    }
    string[]matrix = new string[count];
    int k=0;
    for (int i = 0; i < list.Length; i++)
    {
        if(list[i]==ch[0])
            k++;
        else
            matrix[k]+=list[i];
    }
    return matrix;
}

string[]listArray=FillArray(5);
string[]array=SelectionArray(listArray);
Console.WriteLine($"[{String.Join(",",listArray)}] [{listArray.Length}]");
Console.WriteLine($"[{String.Join(",",array)}] [{array.Length}]");