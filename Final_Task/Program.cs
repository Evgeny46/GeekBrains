/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма.  */


Console.Clear();

System.Console.WriteLine("Введите количество символов в массиве: ");
int elements = int.Parse(Console.ReadLine());
string[] array = new string[elements];
string[] array2 = new string[array.Length];

void InitArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент массива под индексом {i}: ");
        arr[i] = Console.ReadLine();
    }
    
}   

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

void ArraySort(string[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            array2[i] = array[i];
            System.Console.Write(array2[i] + " ");
        }
    }
}


InitArray(array);
System.Console.WriteLine("Заданный массив: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Массив, элементы которого меньше либо равны 3 символам: ");
ArraySort(array);
