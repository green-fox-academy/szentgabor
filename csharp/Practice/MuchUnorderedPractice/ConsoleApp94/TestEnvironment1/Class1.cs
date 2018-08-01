using NUnit.Framework;

namespace ConsoleApp94
{
    [TestFixture]
    public class Class1
    {
        Count szotar = new Count();

        [TestCase("a")]
        public void IsSingleAEquelToNumberOfAs(string word)
        {
            Assert.AreEqual(1,szotar.LetterCounter(word)[word[0]]);
        }
    }
}