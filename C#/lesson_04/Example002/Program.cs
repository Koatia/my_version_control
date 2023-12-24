// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// тип возвращающего значения + Название + ()+ {}


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 101);
        Console.Write(array[i] + " ");
    }
}


int FindNumber()
{
    int countNumber = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            countNumber = countNumber + 1;
        }
    }
    return countNumber;
}

PrintArray();
int newNum = FindNumber();

Console.WriteLine("\n" + newNum);