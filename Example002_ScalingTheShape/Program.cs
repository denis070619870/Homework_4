//Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)"
// --коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// --В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

int xa = 1, ya = 1,
        xb = 41, yb = 8,
        xc = 60, yc = 10;


Console.WriteLine("Введите коэффициент масштабирования: 2, 4 или 0,5: ");
double k = double.Parse(Console.ReadLine());

if( k == 2 && k <3 && k > 1)
{
    xa = 1 * 2; ya = 1 * 2;
    xb = 41 * 2; yb = 8 * 2;
    xc = 60 * 2; yc = 10 * 2;
}
if( k == 4 && k <5 && k > 3)
{
    xa = 1 * 4; ya = 1 * 4;
    xb = 41 * 4; yb = 8 * 4;
    xc = 60 * 4; yc = 10 * 4;
}
//if( k == 0,5)
//{
//    xa = 1 * 0,5; ya = 1 * 0,5;
//    xb = 41 * 0,5; yb = 8 * 0,5;
//    xc = 60 * 0,5; yc = 10 * 0,5;
//}

Console.SetCursorPosition(xa, ya);
Console.Write("+");
Console.SetCursorPosition(xb, yb);
Console.Write("+");
Console.SetCursorPosition(xb, yb);
Console.Write("+");

int x = xa, y =ya;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}