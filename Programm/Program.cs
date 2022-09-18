// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int ConvertInputElements(string input)  // Конвертируем тип внесенных данных
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());

    return output;
}

void ShowArray(string[] array)      // Показываем полученный массив
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CheckCountLimitElementsArray(string[] array, int lengthLimitSize) // посчитали сколько элементов подходит под  заданный лимит символов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimitSize) count++;
    }
    return count;
}

void CreateNewArray(string[] oldArray, string[] newArray, int lengthLimitSize) // создали новый массив 
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimitSize)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

string ShowFinalArray(string[] array) // показали новый массив
{
    string resultArray  = string.Empty;
    resultArray = " ";
    for (int i = 0; i < array.Length; i++)
    {
        resultArray += $"{array[i],1}";
        if (i < array.Length - 1) 
           resultArray += ", ";
    }
    resultArray += " ";
    return resultArray;
}

string questionYesNo = "";
Console.Write("Ввести элементы массива вручную? (yes/no): ");
questionYesNo = Console.ReadLine();

string[] newArray = new string[] { };

if(questionYesNo == "yes")
{
    int size = ConvertInputElements("Введите количество элементов массива: ");
    newArray = new string[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($" Введите {i + 1} элемент массива: ");
        newArray[i] = Console.ReadLine();
    }    
}
if(questionYesNo == "no")
     
    newArray = new string[] {"1234", "1567", "-2", "computer science"};

Console.WriteLine();
Console.WriteLine("Введенный массив:");    
ShowArray(newArray);

int lengthLimitSize = 3;

int countElements = CheckCountLimitElementsArray(newArray, lengthLimitSize);

string[] finalArray = new string[countElements];

CreateNewArray(newArray, finalArray, lengthLimitSize);

Console.WriteLine();
Console.WriteLine($"Новый массив из строк, длина которых меньше, либо равна 3 символам: {ShowFinalArray(finalArray)}");
