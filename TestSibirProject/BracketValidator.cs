using System;
using System.Collections.Generic;
namespace TestSibirProject
{
    class BracketValidator
    {
        public static bool ValidateBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char bracket in input)
            {
                if (IsOpeningBracket(bracket))
                {
                    stack.Push(bracket);
                }
                else
                {
                    if (stack.Count == 0 || !IsMatchingBracket(stack.Pop(), bracket))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static bool IsOpeningBracket(char bracket)
        {
            return bracket == '(' || bracket == '[' || bracket == '{';
        }

        public static bool IsMatchingBracket(char openingBracket, char closingBracket)
        {
            return (openingBracket == '(' && closingBracket == ')') ||
                   (openingBracket == '[' && closingBracket == ']') ||
                   (openingBracket == '{' && closingBracket == '}');
        }
    }

}

