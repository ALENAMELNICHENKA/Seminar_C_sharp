// Выводит случайное трехзначное число и удаляет вторую цифру этого числа

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int num1 = num / 100;
int num2 = num / 10;
int num3 = num % 10;
Console.WriteLine("результат: " + num1 + num3);


