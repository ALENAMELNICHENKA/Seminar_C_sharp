﻿// Выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int num = new Random().Next(10, 100);
Console.WriteLine(num);
//нам нужно число разделить на две части. num1 и num2
//для первого числа - делим его на 10
int num1 = num / 10; // 94 / 10 = 9 - остаток целого первого числа - 9
int num2 = num % 10; // 94 % 10 = 4 - делим на модуль, получаем остаток от деления -второе число - 4

if(num1 > num2)
{
    Console.WriteLine("наибольшая цифра: " + num1);//Console.WriteLine($" max = {num1}), где $ - это интерполятор строки для вывода числа
}
else
{
   Console.WriteLine("наибольшая цифра: " + num2);
}