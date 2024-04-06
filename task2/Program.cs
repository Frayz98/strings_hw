// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string myString = "AbCdEf-!";

static string UpperToLower(string myString)
{
    string result = "";

    for (int i = 0; i < myString.Length; i++)
    {
        char temp = myString[i];
        if (Char.IsUpper(temp))
        {
            result += Char.ToLower(temp);
        }
        else
        {
            result += temp;
        }
    }

    return result;
}

string result = UpperToLower(myString);
Console.WriteLine(result);