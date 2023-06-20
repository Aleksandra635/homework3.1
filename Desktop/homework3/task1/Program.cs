// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Palindrom(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = Palindrom("Введите пятизначное число: ");

void FindPalindrom (int number1)
{
if (number1 > 9999 && number1 < 100000)
{
    if (number1/10000 == number1%10 && number1%10000/1000 == number1%100/10)
    {
        Console.Write($" {number1} --> это палиндром");
    }
    else 
    {
        Console.Write($" {number1} --> это не палиндром");
    }
}
else 
{
    Console.Write("Ошибка. Введите пятизначное число");
}
}
FindPalindrom(number);