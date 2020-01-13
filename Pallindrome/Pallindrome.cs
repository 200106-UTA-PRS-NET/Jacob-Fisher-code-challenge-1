using System;

namespace Pallindrome
{
    public static class Pallindrome
    {
        public static bool IsPalindrome(string input)
        {
            string cleaned = CleanString(input);
            int maxLen = cleaned.Length - 1;
            for(int i=0; i<=maxLen-i; i++)
            {
                if (cleaned[i] != cleaned[maxLen - i])
                {
                    return false;
                }
            }
            return true;
        }
        private static string CleanString(string input)
        {
            string retString = input.ToLower();
            char[] valid = new char[retString.Length];
            int index = 0;
            foreach(char letter in retString)
            {
                if((letter>='a'&&letter<='z')|| (letter >= 'A' && letter <= 'Z') || (letter >= '0' && letter <= '9'))
                {
                    valid[index++] = letter;
                }
            }
            return new string(valid).Trim('\0');
        }
    }
}
