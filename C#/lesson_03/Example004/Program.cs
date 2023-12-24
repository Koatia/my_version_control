// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];

if (num > 99 && num < 1000)
{
    array[0] = num % 10;
    array[1] = num / 10 % 10;
    array[2] = num / 100;

    Console.WriteLine($"[{string.Join(", ", array)}]");
}
else
{
    System.Console.WriteLine("Число не подходит");
}