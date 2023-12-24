// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int GetNumber()
{
    string numberPerson = "";

    for (int i = 0; i < array.Length; i++)
    {
        numberPerson = numberPerson + array[i];
    }

    return Convert.ToInt32(numberPerson);
}

PrintArray();
int newNum = GetNumber();

System.Console.WriteLine("\n" + newNum);