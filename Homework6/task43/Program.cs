int GetNumberFromUser(string messege)
{
    int result = 0;
    Console.WriteLine(messege);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double InterSectionPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x};{y})");
    return x;
}
Console.WriteLine("Введите значения переменных b1, k1, b2, k2 для нахождения точки пересечения");
int b1 = GetNumberFromUser ("Введите значение b1: ");
int k1 = GetNumberFromUser ("Введите значение k1: ");
int b2 = GetNumberFromUser ("Введите значение b2: ");
int k2 = GetNumberFromUser ("Введите значение k2: ");
double result = InterSectionPoint (b1, k1, b2, k2);

