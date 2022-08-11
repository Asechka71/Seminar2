/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 99)
{
    int number1 = number / 100;
    int ThirdDigital = number1 % 10;
    Console.WriteLine($"Третья цифра числа: {ThirdDigital}");
    break;
}       
if (number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
    
