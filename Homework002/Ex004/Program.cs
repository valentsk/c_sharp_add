// Написать функции:
// Sort

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0; 
    while (index < length)
    {
        Console.Write(array[index]);
        if (index < length - 1)
        {
        Console.Write(", ");    
        }
        index++;
    }
    Console.WriteLine();
}

void SortArrayBuble(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        for (int indexJ = 0; indexJ < length - 1; indexJ++) // сравниваем каждый indexовый элемент с остальными и меняем их местами
        {
            if (array[indexJ] > array[indexJ + 1])
            {
                int temp = array[indexJ];
                array[indexJ] = array[indexJ + 1];
                array[indexJ + 1] = temp;
            }
        }
    }
}

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int [] arrayOne = new int[size]; 

FillArray(arrayOne);
PrintArray(arrayOne);
SortArrayBuble(arrayOne);
Console.WriteLine("Сортированный массив: ");
PrintArray(arrayOne);
