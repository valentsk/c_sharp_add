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
    Console.WriteLine();
}

void RemoveArray(int[] array)
{
    int length = array.Length;
    int [] arrayNew = new int[length - 1]; 
    int index = 0;
    int indexNew = 0;

    int indexNumber = new Random().Next(0, length); // выбирает случайный индекс
    Console.WriteLine($"Число, которое удалится из массива: {array[indexNumber]}, индекс: {indexNumber}");
 
    while (index < length)
    {
        if (index == indexNumber)
        {
            index++; // пропускаем индекс в 1 массиве
        }
        else
        {
            arrayNew[indexNew] = array[index];
            Console.Write(arrayNew[indexNew]);
            if (index < length - 1)
            {
               Console.Write(", ");    
            }
            index++;
            indexNew++;
        }

    }
    Console.WriteLine();

}

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int [] arrayOne = new int[size]; 

FillArray(arrayOne);
PrintArray(arrayOne);
AddArray(arrayOne);
RemoveArray(arrayOne);