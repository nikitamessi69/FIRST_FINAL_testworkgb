/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/


string[] array = { "hello", "2", "world", ":-)", "1234", "1567",
"-2", "computer science", "Russia", "Denmark", "Kazan" };

int count = FindArray(array);
int FindArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("[");
        Console.ResetColor();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("]");
        Console.ResetColor();
    }
}

string[] resultArray = FillArray(array, count);
PrintArray(resultArray);