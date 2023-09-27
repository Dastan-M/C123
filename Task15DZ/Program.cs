// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру");
int N = Convert.ToInt32(Console.ReadLine());

if (N==1)
{
    Console.Write("нет");
}
else if (N==2)
{
    Console.Write("нет");
}
else if (N==3)
{
    Console.Write("нет");
}
else if (N==4)
{
    Console.Write("нет");
}
else if (N==5)
{
    Console.Write("нет");
}
else if (N==6)
{
    Console.Write("да");
}
else if (N==7)
{
    Console.Write("да");
}
else
Console.Write("нет такого дня недели");