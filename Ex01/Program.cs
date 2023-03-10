/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами
Пример: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
void SelectedArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arr1 = new string[7] { "Hello", "123", "При", "вет", "ики !!!", ":-))", ";-)"};
string[] arr2 = new string[arr1.Length];

// Печать заданного первого массива.
PrintArray(arr1);

// Выборка и формирование второго массива из всех значений первого массива <= 3м символам.
SelectedArray(arr1, arr2);

// Печать второго массива, значения из 3-х символов и менее. 
Console.Write("-> ");
PrintArray(arr2);