// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int F3 = N % 10;
Console.WriteLine(F3);

while (N>999)
{
    N/=10;
}
Console.WriteLine(N%10);
if (N<100)
{
Console.WriteLine("третьей цифры нет");
}