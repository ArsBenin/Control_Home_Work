/*
Написать программу которая из имеющего массива строк формирует
массив строк, длинна которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма.
При решении не рекомедуется пользоваться коллекциями, лучше обойтись исключительно массивами
*/

// Метод ввода числа элементов массива 
int GetNumberDemension()
{
    int result = 0;
    Console.WriteLine("Введите число элементов массива:");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не натурально число. Введите корректное число элементов массива");
        }
    }

    return result;
}

//Метод ввода элемента массива 
string GetElements()
{
    Console.WriteLine("Введите элемент массива:");
    string result = Console.ReadLine();
    return result;
}

// Метод заполнения массива 
string[] GetArray(int dimension)
{
    string[] arr = new string[dimension];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetElements();
    }

    return arr;
}

// Метод рассчета количества элементов нового массива 
int GetNewArrayLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

//Метод заполнения нового массива 
string[] GetNewArray(string[] arr, int n)
{
    int j = 0;
    string[] newarr = new string[n];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    return newarr;
}

// Метод вывода массива 
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"({arr[i]}) ");
    }
}


int dimension = GetNumberDemension();
string[] array = GetArray(dimension);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int newdimension = GetNewArrayLength(array);
string[] newarray = GetNewArray(array, newdimension);
PrintArray(newarray);