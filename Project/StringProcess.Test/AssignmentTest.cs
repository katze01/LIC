using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringProcess.Test
{
    /// <summary>
    /// Test IsPalindromeOrAnagramOfPalindrome in Assignment
    /// </summary>
    [TestClass]
    public class AssignmentTest
    {
        private IAssignment _test;

        [TestInitialize]
        public void Setup()
        {
            var mock = new MockHelper();
            _test = new Assignment(mock.GetMock().Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _test = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Input String is null")]
        public void IsPalindromeOrAnagramOfPalindrome_TestNull()
        {
            _test.IsPalindromeOrAnagramOfPalindrome(null);
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_TestEmpty()
        {
            Assert.AreEqual(true, _test.IsPalindromeOrAnagramOfPalindrome(""));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_Palindrome()
        {
            Assert.AreEqual(true, _test.IsPalindromeOrAnagramOfPalindrome("anna"));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_PalindromeAndAnagram()
        {
            Assert.AreEqual(true, _test.IsPalindromeOrAnagramOfPalindrome("aaaaaaaa"));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_NotPalindromeButAnagram()
        {
            Assert.AreEqual(true, _test.IsPalindromeOrAnagramOfPalindrome("aaaaaaaab"));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_PalindromeWithOverlap()
        {
            Assert.AreEqual(true, _test.IsPalindromeOrAnagramOfPalindrome("donotbobtonod"));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_AnagramOfPalindromeWithoutOverlap()
        {
            Assert.AreEqual(true, _test.IsPalindromeOrAnagramOfPalindrome("igdedgide"));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_NotPalindromeNotAnagram1()
        {
            Assert.AreEqual(false, _test.IsPalindromeOrAnagramOfPalindrome("caaaaaaaab"));
        }

        [TestMethod]
        public void IsPalindromeOrAnagramOfPalindrome_NotPalindromeNotAnagram2()
        {
            Assert.AreEqual(false, _test.IsPalindromeOrAnagramOfPalindrome("owefhijpfwai"));
        }
    }
}
