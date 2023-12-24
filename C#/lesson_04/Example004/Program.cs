// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
        Console.Write(array[i] + " ");
    }
}

int GetNumber()
{
    int countNumber = 0;

    for (int i = 0; i < array.Length; i++)
    {
        bool isFind = false;

        for (int j = 2; j < array[i]; j++)
        {
            if (array[i] % j == 0)
            {
                isFind = true;
            }
        }

        if (isFind == false)
        {
            countNumber = countNumber + 1;
        }
    }

    return countNumber;
}

PrintArray();
System.Console.WriteLine();
System.Console.WriteLine(GetNumber());
