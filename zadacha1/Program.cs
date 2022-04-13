// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы
double b1 = 1;
double k1 = 5;
double b2 = 2;
double k2 = 4;

if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Координата точки пересечения двух прямых " + "(" + x + ","+ y +")");    
}
