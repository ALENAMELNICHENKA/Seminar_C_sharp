/* Задача 44. Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
если N = 5 -> 0 1 1 2 3
если N = 3 -> 0 1 1
если N = 7 -> 0 1 1 2 3 5 8*/

int GetNumber(string message)
{
    System.Console.Write($"Введите значение {message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetNumber("N -> ");
int number1 = 0;
int number2 = 1;

Console.WriteLine(number1);
Console.WriteLine(number2);
int next = 0;

for (int i = 0; i < number; i++)
{
    next = number1 + number2;
    Console.WriteLine(next);

    number1 = number2;
    number2 = next;

}
