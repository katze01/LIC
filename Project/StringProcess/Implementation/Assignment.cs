using System;

namespace StringProcess
{
    /// <summary>
    /// My Assignment used to check whether an input string is a palindrome or an anagram of a palindrome 
    /// </summary>
    public class Assignment : IAssignment
    {
        private IStringService _stringService;

        public Assignment(IStringService service)
        {
            _stringService = service;
        }

        #region IAssignment Implementations 

        /// <summary>
        /// If the input string is a palindrome or an anagram of a palindrome, return true
        /// otherwise, return false
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public bool IsPalindromeOrAnagramOfPalindrome(string inputString)
        {
            //Validate input string
            StringHelper.Validation(inputString);

            //check whether the input string is a palindrome, or an anagram of a palindrome
            if (_stringService.IsPalindrome(inputString) || _stringService.IsAnagram(inputString))
                return true;

            //otherwise, return false
            return false;
        }
        #endregion
    }
}
