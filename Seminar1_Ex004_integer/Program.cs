// На входе число (N), а на выходе - все целые числа в промежутке между -N....N
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = num * -1;// Заводим переменную, кот.будет работать в цикле num0

while (num0 <= num)
{
    Console.WriteLine(num0);
num0 ++; //чтобы был цикл. Сокращенное num0 +1
}
