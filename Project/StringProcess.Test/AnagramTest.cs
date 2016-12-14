using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringProcess.Test
{
    /// <summary>
    /// Test IsAnagram in StringService
    /// </summary>
    [TestClass]
    public class AnagramTest
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
        public void IsAnagram_TestNull()
        {
            Assert.AreEqual(false, _testStringService.IsAnagram(null));
        }

        [TestMethod]
        public void IsAnagram_TestEmpty()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram(""));
        }

        [TestMethod]
        public void IsAnagram_TestSingleCharacter()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram("a"));
        }

        [TestMethod]
        public void IsAnagram_TestSameCharacter()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram("aaaaaaaa"));
        }

        [TestMethod]
        public void IsAnagram_TestPalindromeWithoutOverlap()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram("anna"));
        }

        [TestMethod]
        public void IsAnagram_TestPalindromeWithOverlap()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram("donotbobtonod"));
        }

        [TestMethod]
        public void IsAnagram_TestAnagramOfPalindromeWithOverlap_1()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram("aaaaaaaab"));
        }

        [TestMethod]
        public void IsAnagram_TestAnagramOfPalindromeWithOverlap_2()
        {
            Assert.AreEqual(true, _testStringService.IsAnagram("igdedgide"));
        }

        [TestMethod]
        public void IsAnagram_TestNotAnagramOfPalindrome_1()
        {
            Assert.AreEqual(false, _testStringService.IsAnagram("caaaaaaaab"));
        }

        [TestMethod]
        public void IsAnagram_TestNotAnagramOfPalindrome_2()
        {
            Assert.AreEqual(false, _testStringService.IsAnagram("owefhijpfwai"));
        }
    }
}
