// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = prompt ("Введите число: ");
cube(num);
int prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void cube(int number)
{
    int i=1;
    while (i<= number)
{
    Console.Write(i * i * i + " ");
    i++;
}
}
