using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringProcess.Test
{
    /// <summary>
    /// Test IsPalindrome in StringService
    /// </summary>
    [TestClass]
    public class PalindromeTest
    {
        private IStringService _testStringService;

        [TestInitialize]
        public void Setup()
        {
            _testStringService = new StringService();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _testStringService = null;
        }

        [TestMethod]
        public void IsPalindrome_TestNull()
        {
            Assert.AreEqual(false, _testStringService.IsPalindrome(null));
        }

        [TestMethod]
        public void IsPalindrome_TestEmpty()
        {
            Assert.AreEqual(true, _testStringService.IsPalindrome(""));
        }

        [TestMethod]
        public void IsPalindrome_TestSingleCharacter()
        {
            Assert.AreEqual(true, _testStringService.IsPalindrome("a"));
        }

        [TestMethod]
        public void IsPalindrome_TestSameCharacter()
        {
            Assert.AreEqual(true, _testStringService.IsPalindrome("aaaaaaaa"));
        }

        [TestMethod]
        public void IsPalindrome_TestPalindromeWithOverlap()
        {
            Assert.AreEqual(true, _testStringService.IsPalindrome("donotbobtonod"));
        }

        [TestMethod]
        public void IsPalindrome_TestPalindromeWithoutOverlap()
        {
            Assert.AreEqual(true, _testStringService.IsPalindrome("anna"));
        }

        [TestMethod]
        public void IsPalindrome_TestNotPalindrome_1()
        {
            Assert.AreEqual(false, _testStringService.IsPalindrome("aaaaaaaab"));
        }

        [TestMethod]
        public void IsPalindrome_TestNotPalindrome_2()
        {
            Assert.AreEqual(false, _testStringService.IsPalindrome("caaaaaaaab"));
        }

        [TestMethod]
        public void IsPalindrome_TestNotPalindrome_3()
        {
            Assert.AreEqual(false, _testStringService.IsPalindrome("owefhijpfwai"));
        }

        [TestMethod]
        public void IsPalindrome_TestNotPalindrome_4()
        {
            Assert.AreEqual(false, _testStringService.IsPalindrome("igdedgide"));
        }

    }
}
