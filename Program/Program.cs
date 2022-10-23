// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Например:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "competer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


int ReadNumber(string message) // метод для призыва пользователя ввести значения в консоль
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] array) // метод печати массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    Console.WriteLine();
}

string[] GetArray(int size) // метод для ввода значений в массив
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Задайте элемент в массиве {i + 1}:");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

int SizeArray(string[] arr, int сhar) // метод чтобы узнать длинну нового массива
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int length = arr[i].Length;
        if (length <= сhar)
        {
            size++;
        }
    }
    return size;
}

string[] ResultGetArray(string[] arr, int size, int сhar) // метод для создания массива с длинной элементов 3 и менее
{
    string[] newArray = new string[size];
    int indexNewArray = 0;
    for (int indexArray = 0; indexArray < arr.Length; indexArray++)
    {
        int length = arr[indexArray].Length;
        if (length <= сhar)
        {
            newArray[indexNewArray] = arr[indexArray];
            indexNewArray++;
        }
    }
    return newArray;
}

int sizeArray = ReadNumber("Задайте размер массива:");
string[] array = GetArray(sizeArray);
Console.WriteLine("Заданный массив:");
PrintArray(array);

int newSizeArray = SizeArray(array, 3);
string[] newArray = ResultGetArray(array, newSizeArray, 3);
Console.WriteLine("Массив с длиной элементов не больше 3:");
PrintArray(newArray);