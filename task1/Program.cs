// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] charsArray = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

string CharsArrayToString(char[,] charsArray)
{
    string res = "";

    for (int i = 0; i < charsArray.GetLength(0); i++)
    {
        for (int j = 0; j < charsArray.GetLength(1); j++)
        {
            res += charsArray[i, j];
        }
    }

    return res;
}

string result = CharsArrayToString(charsArray);

Console.WriteLine(result);