// Напишите программу, которая перевернёт одномерный массив
//последний элемент будет на первом месте, а первый - на последнем и т.д.
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


//Метод получения случ. значений массива
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];//объявляем массив
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);//заполняем случ. числами
    }
    return array;
}

void Revers(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++) 
    {
        int temp = array[i]; // Временная переменная для запоминания эл-та, кот. надо поменять местами
        array[i] = array[array.Length - 1 - i]; //  позицию последнюю записали в первую
        array[array.Length - 1 - i] = temp; //
    }
}

int[] array = GetArray(4, 1, 30);
Console.WriteLine(string.Join(" ", array));
Revers(array);
Console.WriteLine(string.Join(" ", array));
