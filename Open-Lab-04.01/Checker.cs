using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            for (int letter = 0; letter < str.Length - 1; letter++)
            {
                if (str[letter] == str[letter + 1])
                { 
                    return true;
                }

            }
            return false;
        }
    }
}
