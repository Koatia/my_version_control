// Создаем массив и заполняем его случайными числами
Random random = new Random();
int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0, 100);
}

PrintArray(array: arr, text: "Входящий массив: ");
SelectionSort(arr);
PrintArray(array: arr, text: "Исходящий массив:");


// Метод для печати массива
void PrintArray(int[] array, string text)
{
    Console.WriteLine($"{text} [{string.Join(" ", array)}]");
}


// Метод для сортировки массива
int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        // Применение кортежей для обмена значениями позволяет избежать создания временной переменной
        (array[i], array[minPosition]) = (array[minPosition], array[i]);
    }
    return array;
}