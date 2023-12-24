// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

int num = new Random().Next(1, 10);
System.Console.WriteLine("Наше число " + num);

int firstElement = 1;

PrintNumbers(firstElement, num);

void PrintNumbers(int startEl, int endEl)
{
    System.Console.Write(startEl);

    if (startEl == endEl)
    {
        return;
    }

    PrintNumbers(startEl + 1, endEl);
}