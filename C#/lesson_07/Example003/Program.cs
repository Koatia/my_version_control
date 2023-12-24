// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello23” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


string str = "14TeMmrI2";
System.Console.Write(str);
System.Console.Write(" => ");

ShowСonsonants(str);

void ShowСonsonants(string userInput)
{
    if (userInput.Length == 0)
    {
        return;
    }

    string vowels = "aoiyeu";

    if (char.IsLetter(userInput[0]) && !vowels.Contains(char.ToLower(userInput[0])))
    {
        System.Console.Write(userInput[0]);
    }

    ShowСonsonants(userInput.Substring(1));
}