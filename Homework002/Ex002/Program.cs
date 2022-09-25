// Написать функции:
// Если слишком просто, то написать функции Add, Remove, Concat, Sort для массивов
// Concat - функция объединения массивов (1,2,3) + (3,4,5,) = (1,2,3,3,4,5)

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

void AddArray(int[] array)
{
    int length = array.Length;
    int [] arrayNew = new int[length + 1]; 
    int index = 0;
    
    int number = new Random().Next(-100, 100);
    Console.WriteLine($"Число, которое добавляется к массиву: {number}");
//    Console.Write("Введите число, которое необходимо добавить к массиву: ");
//    int number = int.Parse(Console.ReadLine()!);
    
    while (index < length + 1)
    {
        if (index < length)
        {
            arrayNew[index] = array[index];
            Console.Write(arrayNew[index]);
            Console.Write(", ");    
        }
        else
        {
            arrayNew[length] = number;
            Console.Write(arrayNew[length]);
        }
        index++;
    }
}

void RemoveArray(int[] array)
{

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int [] arrayOne = new int[size]; 
// int [] arrayAdd = new int[size + 1]; 
// int [] arrayRemove = new int[size - 1]; 

FillArray(arrayOne);
PrintArray(arrayOne);
AddArray(arrayOne);
