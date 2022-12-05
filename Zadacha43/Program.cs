/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


int numberB1 = ReadInt("Введите число b1: ");
int numberB2 = ReadInt("Введите число b2: ");
int numberK1 = ReadInt("Введите число k1: ");
int numberK2 = ReadInt("Введите число k2: ");
double x = 0;
double y = 0;

if(numberK1 == numberK2)
{
   Console.WriteLine("Прямые не пересекаются");
}
else
{
    x = (numberB2-numberB1)/(numberK2-numberK1);
    y = numberK1 * x + numberB1;
}

Console.WriteLine($"Точка пересечения двух прямых: {y}; {x}");



int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}