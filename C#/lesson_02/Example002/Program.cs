// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 % 1000 =  126  
// 91 => Третьей цифры нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    if (num > 999)
    {
        num = num % 1000;
    }

    int result = num / 100;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не подходит");
}