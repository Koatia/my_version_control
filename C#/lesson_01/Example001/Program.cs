using System;

// Выводим сообщение, предлагающее пользователю ввести свое имя
Console.WriteLine("Введите ваше имя ");

// Читаем строку, введенную пользователем, и сохраняем ее в переменную 'username'
string? username = Console.ReadLine();

// Выводим приветствие, используя интерполяцию строк
Console.WriteLine($"Hello, {username}");