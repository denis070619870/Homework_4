// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

//приравниваем правые части данных равенств:
//k1*x+b1=k2*x+b2
//выразим отсюда x:
//x=(b2-b1)/(k1-k2)
//затем подставим полученное значение х в выражение для у (для любого, например первого) :
//y=k1(b2-b1)/(k1-k2)+b1
//ответ: x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1


Console.WriteLine(" ");

//double k1 = 5;  
//double k2 = 3;  
//double b1 = 4;
//double b2 = 2;

Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

 
double x = (b2 - b1)/(k1 - k2);
//double y = k2 * x + b2;
double y = k1 * x + b1;
 
Console.WriteLine();
Console.WriteLine($"Точка пересечения: X = {x}; Y = {y} ");