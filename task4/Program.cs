// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string myString = "Hello my world";

string[] SplitAndReverseString(string myString)
{
    string[] myStringSplit = myString.Split(" ");
    string[] result = new string[myStringSplit.Length];

    for (int i = 0; i < myStringSplit.Length; i++)
    {
        result[i] = myStringSplit[myStringSplit.Length - i - 1];
    }

    return result;
}

string PrintResult(string myString)
{
    string[] temp = SplitAndReverseString(myString);
    string result = "";

    for (int i = 0; i < temp.Length; i++)
    {
        if (i < temp.Length)
        {
            result += $"{temp[i]} ";
        }
        else
        {
            result += temp[i];
        }
    }

    return result;
}

Console.WriteLine(PrintResult(myString));