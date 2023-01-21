/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double GetNumber(string message)
{
    double result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

double b1 = GetNumber("Введите b1 - ");
double k1 = GetNumber("Введите k1 - ");
double b2 = GetNumber("Введите b2 - ");
double k2 = GetNumber("Введите k2 - ");

if ((b1 == b2) && (k1 == k2)) {Console.WriteLine("Прямые совпадают");}
else if (k1 == k2) {Console.WriteLine("Прямые параллельны");}
else
{
double x=(b2-b1)/(k1-k2);

double y=(k1*(b2-b1))/(k1-k2)+b1;

    Console.WriteLine($"Точка пересечения прямых находиться в координате [{x},{y}] ");
}