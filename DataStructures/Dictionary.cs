using System.Collections.Generic;
using System;

namespace DataStructures
{
    public class Dictionary
    {
        public char FindFistNonRepeatedChar(string s)
        {
            var freChar = new Dictionary<char, int>();

            foreach (Char ch in s)
            {
                if (!freChar.ContainsKey(ch))
                {
                    freChar.Add(ch, 1);
                }

                else
                {
                    freChar[ch] = freChar[ch] + 1;
                }
            }

            char result = '-';

            foreach (var dic in freChar)
            {
                if (dic.Value == 1)
                {
                    result = dic.Key;
                    break;
                }              
            }

            return result;
        }
    }
}