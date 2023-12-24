// вывод на экран двухмерного массива чисел (int)
void ShowImage(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if (matrix[rows, columns] > 0)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}


// закраска области, ограниченной границами (цветом)
void FillImage(int[,] image, int x, int y)
{
    int width = image.GetLength(1);
    int height = image.GetLength(0);

    if (image[y, x] > 0)
        return;
    image[y, x] = 1;
    if (x > 0)
        FillImage(image, x - 1, y);        // заполняем слева
    if (y > 0)
        FillImage(image, x, y - 1);        // сверху
    if (x < width - 1)
        FillImage(image, x + 1, y);        // справа
    if (y < height - 1)
        FillImage(image, x, y + 1);        // снизу
}


int[,] picture = new int[,] {
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,1,0,0,1,1,1,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

ShowImage(picture);
FillImage(picture, 13, 6);
ShowImage(picture);


/*
   Найти факториал числа с помощью рекурсии
       factorial(n) = 1*2*3...*n
   или
       factorial(n) = n*...3*2*1

   например:
       factorial(5) = 5*4*3*2*1
   что можно представить как:
       factorial(5) = 5*factorial(4);

   то есть, если обобщить:
       factorial(n) = n * factorial(n-1)
*/

double Factorial(int n)
{
    if (n > 1)
    {
        return n * Factorial(n - 1);
    }
    return 1;   // 0! и 1! - равны 1
}


Console.Write("Enter number: ");
for (int num = 1; num < 30; num++)
{
    Console.WriteLine($"Factorial number '{num}' = {Factorial(num)}");
}