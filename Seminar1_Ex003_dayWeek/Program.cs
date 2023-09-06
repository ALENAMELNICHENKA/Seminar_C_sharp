// Напишите программу, кот. будет выдавать название дня недели по заданному номеру:
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int DayWeek = int.Parse(strNum);

if (DayWeek == 1)
{
    Console.WriteLine("Понедельник ");
}

else if (DayWeek == 2)
{
    Console.WriteLine("Вторник ");
}

else if (DayWeek == 3)
{
    Console.WriteLine("Среда ");
}

else if (DayWeek == 4)
{
    Console.WriteLine("Четверг ");
}

else if (DayWeek == 5)
{
    Console.WriteLine("Пятница ");
}

else if (DayWeek == 6)
{
    Console.WriteLine("Суббота ");
}

else if (DayWeek == 7)
{
    Console.WriteLine("Воскресенье ");
}

else 
{
    Console.Write("Ввели некорректное число! ");
}