// Написать функции:
// Find, Max, Min для массивов

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

int FindMax(int[] array)
{
    int length = array.Length;
    int index_max = 0;
    int index = 1;
    while (index < length)
    {
        if (array[index] > array[index_max])
        {
            index_max = index;
        }
        index++;
    }
    Console.WriteLine($"Максимальное значение числа в массиве: {array[index_max]}");
    Console.WriteLine($"Индекс максимального значения в массиве (первое вхождение): {index_max}");
    return index_max;
}

int FindMin(int[] array)
{
    int length = array.Length;
    int index_min = 0;
    int index = 1;
    while (index < length)
    {
        if (array[index] < array[index_min])
        {
            index_min = index;
        }
        index++;
    }
    Console.WriteLine($"Минимальное значение числа в массиве: {array[index_min]}");
    Console.WriteLine($"Индекс минимального значения в массиве (первое вхождение): {index_min}");
    return index_min;
}

int [] array = new int[10]; 

FillArray(array);
PrintArray(array);

FindMax(array);
FindMin(array);