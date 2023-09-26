/* Задача 40. Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона меньше суммы двух других сторон.*/


Console.WriteLine("Введите три числа: ");

// Метод получения и вывода данных от пользователя
int GetNumber(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num1 = GetNumber("Введите число 1 -> ");
int num2 = GetNumber("Введите число 2 -> ");
int num3 = GetNumber("Введите число 3 -> ");

if (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2)
{
    Console.WriteLine("Треугольник существует ");
}
else
{
    Console.WriteLine("Треугольник не существует ");
}




