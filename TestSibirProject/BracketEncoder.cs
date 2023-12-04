using System;
namespace TestSibirProject
{
    public class BracketEncoder
    {
        public static string EncodeWithBrackets(string inputStr)
        {
            inputStr = inputStr.ToLower(); // Игнорируем регистр
            char[] resultArr = new char[inputStr.Length];

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currentChar = inputStr[i];
                if (inputStr.Count(c => c == currentChar) == 1)
                    resultArr[i] = '(';
                else
                    resultArr[i] = ')';
            }

            return new string(resultArr);
        }
    }
}

