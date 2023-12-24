using System;

// Очистка консоли
Console.Clear();

// Задание координат точек
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

// Рисование точек
Console.SetCursorPosition(xa, ya);
Console.WriteLine("#");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("#");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("#");

// Начальные координаты
int x = xa, y = ya;

// Количество итераций
int count = 0;

while (count < 10000)
{
    // Выбор случайной точки
    int point = new Random().Next(0, 3);

    // Перемещение в середину отрезка
    if (point == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (point == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (point == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    // Рисование точки
    Console.SetCursorPosition(x, y);
    Console.WriteLine("#");

    // Увеличение счетчика
    count += 1;
}

// Возврат курсора в исходную точку
Console.SetCursorPosition(xb, yb);
