/* Задача 45. Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного копирования.*/

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int[] array = FillArray(5, 10, 20);
Console.WriteLine(string.Join(" ", array));

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    
    return arrayCopy;
}

int[] arrayCopy = CopyArray(array);
Console.WriteLine(string.Join(" ", arrayCopy));
