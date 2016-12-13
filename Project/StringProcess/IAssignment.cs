
namespace StringProcess
{
    public interface IAssignment
    {
        /// <summary>
        /// If the input string is a palindrome or an anagram of a palindrome, return true
        /// otherwise, return false
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        bool IsPalindromeOrAnagramOfPalindrome(string inputString);
    }
}
