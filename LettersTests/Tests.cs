using NUnit.Framework;
using Letters;

namespace LettersTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("wood", true)]
        [TestCase("wode", true)]
        [TestCase("din", true)]
        [TestCase("dine", true)]
        [TestCase("sin", false)]
        public void GivenWord_CaseSensitiveReusuableWordFromCharactersChecker_ReturnsBooleanIfInList(string word, bool outcome)
        {
            var q = new LettersExample();
            Assert.AreEqual(outcome, q.CaseSensitiveReusuableWordFromCharactersChecker(word));
        }


        [TestCase("wood", true)]
        [TestCase("wode", true)]
        [TestCase("din", true)]
        [TestCase("dine", true)]
        [TestCase("sin", true)]
        public void GivenWord_CaseInsensitiveReusuableWordFromCharactersChecker_ReturnsBooleanIfInList(string word, bool outcome)
        {
            var q = new LettersExample();
            Assert.AreEqual(outcome, q.CaseInsensitiveReusuableWordFromCharactersChecker(word));
        }
    }
}
