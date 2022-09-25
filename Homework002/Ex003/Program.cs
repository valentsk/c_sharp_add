// Написать функции:
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

void ConcatArray(int[] array1, int[] array2)
{
    int length1 = array1.Length;
    int length2 = array2.Length;
    int lengthNew = length1 + length2;
    int [] arrayNew = new int[lengthNew]; 
    int index1 = 0;
    int index2 = 0;
    for (int indexNew = 0; indexNew < lengthNew; indexNew++)
    {
        if (indexNew < length1)
        {
            arrayNew[indexNew] = array1[index1];
            Console.Write($"{arrayNew[indexNew]}, ");
            index1++;
        }
        else
        {
            arrayNew[indexNew] = array2[index2];
            Console.Write($"{arrayNew[indexNew]}");
            if (indexNew < lengthNew - 1)
            {
                Console.Write(", ");
            }
            index2++;
        }
    }
    Console.WriteLine();
}

Console.Write("Введите размерность первого массива: ");
int sizeOne = int.Parse(Console.ReadLine()!);
int [] arrayOne = new int[sizeOne]; 

Console.Write("Введите размерность второго массива: ");
int sizeTwo = int.Parse(Console.ReadLine()!);
int [] arrayTwo = new int[sizeTwo]; 


FillArray(arrayOne);
PrintArray(arrayOne);
FillArray(arrayTwo);
PrintArray(arrayTwo);

ConcatArray(arrayOne, arrayTwo);
