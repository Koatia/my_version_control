// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetSumNember(num)); //123

int GetSumNember(int newNum) //123
{
    if (newNum == 0)
    {
        return 0;
    }

    return newNum % 10 + GetSumNember(newNum / 10);  // 3 + 2 +1 +0= 6
}