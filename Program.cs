// 
string Parametr(string message) // метод для ввода значений с клавиатуры
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    if (value==string.Empty)
    {
        Console.WriteLine("Пустые строки и символы отличные от цифр вводить нельзя!");
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
    //int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            list += array[i]+"/";
            //count++;
        }
    }
    //string[]matrix = new string[count];
    string [] matrix = list.Split("/");
    return matrix;
}

string[]listArray=FillArray(5);
string[]array=SelectionArray(listArray);
Console.WriteLine($"[{String.Join(",",listArray)}]");
Console.WriteLine($"[{String.Join(",",array)}]");