double Distance (double x1, double y1, double x2, double y2)
{
double Distance1 = Math.Round (Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)), 3);
return Distance1;
}

Console.WriteLine ("Введите x1");
double x1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите y1");
double y1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Введите x2");
double x2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите y2");
double y2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Расстояние равно "+Distance (x1, y1, x2, y2));

// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Distance(double x1, double y1, double x2, double y2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3);
// }

// double PromtDobleNumbers()
// {
//     return Convert.ToDouble(Console.ReadLine());
// }

// Console.WriteLine("Введите x1");
// double x1 = PromtDobleNumbers();
// Console.WriteLine("Введите y1");
// double y1 = PromtDobleNumbers();

// Console.WriteLine("Введите x2");
// double x2 = PromtDobleNumbers();
// Console.WriteLine("Введите y2");
// double y2 = PromtDobleNumbers();

// Console.WriteLine("Расстояние равно " + Distance(x1, y1, x2, y2));