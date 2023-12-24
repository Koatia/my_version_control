// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] array = new int[3, 4];
double[] array2 = new double[array.GetLength(0)];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindElementsArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sumElement = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElement += array[i, j];
        }
        array2[i] = sumElement / array.GetLength(1);
    }
}

void PrintArray2()
{
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.Write(array2[i] + " ");
    }
    System.Console.WriteLine();
}

CreateArray();
PrintArray();
FindElementsArray();
PrintArray2();