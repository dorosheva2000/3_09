/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double InputNumber(string massege)
{
    Console.WriteLine(massege);
    return double.Parse(Console.ReadLine()!);
}

void IntersectionPoint(double k1, double b1, double k2, double b2, double[] arr)
{
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;
}

double[] point = new double[2];
double k1 = InputNumber("Введите k1");
double b1 = InputNumber("Введите b1");
double k2 = InputNumber("Введите k2");
double b2 = InputNumber("Введите b2");

IntersectionPoint(k1, b1, k2, b2, point);
Console.WriteLine($"({point[0]};{point[1]})");