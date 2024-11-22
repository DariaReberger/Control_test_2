// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"Hello", "2", "wor", ":-)"};
int count = 0;
int size_arr = 0;

int GetSize(string[] array2)
{
    foreach(string e in array2)
    {
        if(e.Length<=3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] arr, int c)
{
    string[] result = new string[c];
    foreach(string e in arr)
    {
        if(e.Length<=3)
        {
            result[size_arr]=e;
            size_arr++;
        }
    }
    return result;
}

void PrintArr(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}


int size = GetSize(array);
string[] newarray = NewArray(array, size);
PrintArr(newarray);