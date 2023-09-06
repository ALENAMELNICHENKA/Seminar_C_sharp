//программа, кот.на вход принимает два числа и проверяет, явл. ли первое число квадратом второго.
//Данные:
//а = 25, b = 5 -> да
//а = 2, b 10 -> нет

Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

//Находим квадрат второго числа:
int sqr = num2 * num2;
//Сравиниваем. Если число 1 является квадратом числа 2, то
if (sqr == num1)
{
Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}