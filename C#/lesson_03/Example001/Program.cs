using System;

// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Создаем пустой массив на 5 элементов
int[] array = new int[5];

bool isFind = false;

// Заполняем массив случайными числами от 0 до 9
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    System.Console.Write(array[i] + " ");
    if (array[i] == num) isFind = true;
}

if (isFind == true)
{
    System.Console.WriteLine(" => Да");
}
else
{
    System.Console.WriteLine(" => Нет");
}