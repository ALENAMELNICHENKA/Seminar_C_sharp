/* Задача 42. Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int GetNumber()
{
    System.Console.Write("Enter number -> ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] Convertation(int number)
{
    int[] array = new int[32];
    for (int i = 0; number > 0; i++)
    {
        array[array.Length - 1 - i] = number % 2;
        number /= 2;
    }
    return array;
}

Console.WriteLine();
int number = GetNumber();
string print = string.Join(", ", Convertation(number)); /* string.Join принимает 2 параметра:
                                                        1 - это разделитель(сепаратор), 2 - массив*/
Console.WriteLine(print);



