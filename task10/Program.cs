/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10;
int SecondDigital = number1 % 10;

Console.WriteLine($"Вторая цифра числа: {SecondDigital}");