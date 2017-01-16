using System;
using System.Text.RegularExpressions;

//test
//test2
namespace StringProcess
{
    public class StringHelper
    {
        public static void Validation(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException(null, "Input String is null");

            if (!Regex.IsMatch(inputString, "^[a-z]+$"))
            {
                throw new ArgumentException("Not Valid Input");
            }
        }
    }
}
