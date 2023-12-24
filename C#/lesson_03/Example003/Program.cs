// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];
int[] array2 = new int[num / 2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 20);
    System.Console.Write(array[i] + " ");

}

System.Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
{
    if (i == array.Length - 1 - i)
    {
        return;
    }

    array2[i] = array[i] * array[array.Length - 1 - i];
    Console.Write(array2[i] + " ");
}