/* Задайте двумерный массив размером m x n
заполненный случайными целыми числами.
m = 3,  n = 4.
1  4  8 19
5 -2 33 -2
77 3  8  1 */

int GetNumber(string message)
{
    System.Console.Write($"Введите значение {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int rows = GetNumber("rows");
int columns = GetNumber("columns");

int[,] array = GetMatrix(rows, columns, 0, 9);
PrintMatrix(array);

int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        matrix[i, j] = random.Next(minValue, maxValue +1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
