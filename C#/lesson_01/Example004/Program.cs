﻿using System;

// https://qna.habr.com/q/1160590
// Внутри строки в нынешнем шарпе хранятся в utf-16, а в консоли - в utf-8.
// чтобы работало, надо указать явно кодировку utf-16:
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

// Выводим сообщение, приглашающее пользователя ввести имя
Console.Write("Введите имя пользователя: ");

// Считываем введенное пользователем имя. 
string? username = Console.ReadLine();

// Проверяем, не равно ли введенное имя "masha" (в нижнем регистре)
// Для этого приводим введенное имя к нижнему регистру с помощью метода ToLower()
if (username?.ToLower() == "masha" || username?.ToLower() == "маша")
{
    // Если имя равно "masha", выводим соответствующее сообщение
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    // Если имя не равно "masha", выводим приветствие с именем пользователя
    // Используем интерполяцию строк для более эффективного форматирования
    Console.WriteLine($"Привет, {username}");
}

// Ожидаем нажатия любой клавиши для закрытия консоли
// Console.ReadLine();