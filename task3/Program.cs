// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Введите произвольную строку");
string userInput = Console.ReadLine();

bool CheckIsPalindrome(string userInput) {
    for (int i = 0; i < userInput.Length / 2; i++) {
        if (userInput[i] != userInput[userInput.Length - i - 1]) {
            return false;
        }
    }

    return true;
}

bool result = CheckIsPalindrome(userInput);
Console.WriteLine(result ? "Да" : "Нет");