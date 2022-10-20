// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение 'b1'");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение 'k1'");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение 'b2'");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение 'k2'");
double k2 = double.Parse(Console.ReadLine()!);


double x = FindX(b1, k1, b2, k2);
double y = FindY(b1, k1, b2, k2);

if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают (бесконечное множество точек пересечения)");
else if (k1 == k2) Console.WriteLine("Прямые не пересекаются (прямые параллельны)");
     else Console.WriteLine($"Точка пересечения двух заданных прямых -> ({x}; {y})");



double FindX(double number1, double number2, double number3, double number4) // метод нахождения координаты X
{
    double x = 0;
    double x1 = k1 - k2;
    double x2 = b2 - b1;
    if (x1 == x2) x = 0;
    else x = x2 / x1;
    
    if (x == -0) x = 0;

    return x;
}

double FindY(double number1, double number2, double number3, double number4) // метод нахождения координаты Y
{
    double x = FindX(number1, number2, number3, number4);
    double y = 0;
    y = k1 * x + b1;
    
    return y;
}




