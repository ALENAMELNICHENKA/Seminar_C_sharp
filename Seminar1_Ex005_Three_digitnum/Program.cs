// На входе трехзначное число, на выходе последняя цифра введенного числа

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    Console.WriteLine(num % 10);
}

else
{
    Console.Write("Ошибочный ввод данных! ");
}

