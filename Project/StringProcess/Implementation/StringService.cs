﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StringProcess
{
    /// <summary>
    /// StringService, used to check whether an input string is a plalindrome by linq reverse.
    /// and check whether an input string is an anagram of a plalindrome
    /// </summary>
    public class StringService : IStringService
    {
        #region IStringService Implementations 

        /// <summary>
        /// If the input string is a palindrome or an anagram of a palindrome, return true
        /// otherwise, return false
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public bool IsPalindrome(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException("Input String is null");

            // if the reversed string equals to the input string, then the input string is a palindrome 
            string reversed = new string(Enumerable.Range(1, inputString.Length).Select(i => inputString[inputString.Length - i]).ToArray());
            return String.Compare(inputString, reversed, true) == 0;
        }

        /// <summary>
        /// If the input string is an anagram of a palindrome, return true
        /// otherwise, return false
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public bool IsAnagram(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException("Input String is null");

            //Compute the times that each character in the input string
            IDictionary<string, int> characterList = new Dictionary<string, int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                string item = inputString.Substring(i, 1);
                if (characterList.ContainsKey(item))
                {
                    characterList[item]++;
                }
                else
                {
                    characterList.Add(item, 1);
                }
            }

            //If the string can be a palindrome, 
            List<KeyValuePair<string, int>> oddCharacters = 
                (from m in characterList where m.Value % 2 == 1 select m).ToList();

            if (oddCharacters.Count <= 1)
                return true;

            return false;
        }
        #endregion
    }
}
