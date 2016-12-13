using Moq;

namespace StringProcess.Test
{
    public class MockHelper
    {
        public Mock<IStringService> GetMock()
        {
            Mock < IStringService> mock = new Mock<IStringService>();
            mock.Setup(m => m.IsPalindrome("")).Returns(true);
            mock.Setup(m => m.IsPalindrome("anna")).Returns(true);
            mock.Setup(m => m.IsPalindrome("aaaaaaaa")).Returns(true);
            mock.Setup(m => m.IsPalindrome("aaaaaaaab")).Returns(false);
            mock.Setup(m => m.IsPalindrome("caaaaaaaab")).Returns(false);
            mock.Setup(m => m.IsPalindrome("donotbobtonod")).Returns(true);
            mock.Setup(m => m.IsPalindrome("owefhijpfwai")).Returns(false);
            mock.Setup(m => m.IsPalindrome("igdedgide")).Returns(false);

            mock.Setup(m => m.IsAnagram("")).Returns(true);
            mock.Setup(m => m.IsAnagram("anna")).Returns(true);
            mock.Setup(m => m.IsAnagram("aaaaaaaa")).Returns(true);
            mock.Setup(m => m.IsAnagram("aaaaaaaab")).Returns(true);
            mock.Setup(m => m.IsAnagram("caaaaaaaab")).Returns(false);
            mock.Setup(m => m.IsAnagram("donotbobtonod")).Returns(true);
            mock.Setup(m => m.IsAnagram("owefhijpfwai")).Returns(false);
            mock.Setup(m => m.IsAnagram("igdedgide")).Returns(true);
            return mock;
        }
    }
}
