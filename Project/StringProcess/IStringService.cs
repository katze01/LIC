
namespace StringProcess
{
    public interface IStringService
    {
        /// <summary>
        /// If the input string is a palindrome or an anagram of a palindrome, return true
        /// otherwise, return false
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        bool IsPalindrome(string inputString);

        /// <summary>
        /// If the input string is an anagram of a palindrome, return true
        /// otherwise, return false
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        bool IsAnagram(string inputString);
    }
}
