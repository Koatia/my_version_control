// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца


// Создаем двумерный массив (например, 3x3)
int[,] array = new int[,]
{
    { 6, 2, 3 },
    { 4, 0, 6 },
    { 7, 8, 9 }
};

// Находим индексы наименьшего элемента
int minElement = int.MaxValue;
int minRow = -1;
int minColumn = -1;

for (int row = 0; row < array.GetLength(0); row++)
{
    for (int col = 0; col < array.GetLength(1); col++)
    {
        if (array[row, col] < minElement)
        {
            minElement = array[row, col];
            minRow = row;
            minColumn = col;
        }
    }
}

// Создаем новый массив без строки и столбца с наименьшим элементом
int[,] trimmedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
int newRow = 0;

for (int row = 0; row < array.GetLength(0); row++)
{
    if (row == minRow)
        continue;

    int newColumn = 0;
    for (int col = 0; col < array.GetLength(1); col++)
    {
        if (col == minColumn)
            continue;

        trimmedArray[newRow, newColumn] = array[row, col];
        newColumn++;
    }
    newRow++;
}

// Выводим новый массив
Console.WriteLine("Новый массив без строки и столбца с наименьшим элементом:");
for (int row = 0; row < trimmedArray.GetLength(0); row++)
{
    for (int col = 0; col < trimmedArray.GetLength(1); col++)
    {
        Console.Write(trimmedArray[row, col] + " ");
    }
    Console.WriteLine();
}
