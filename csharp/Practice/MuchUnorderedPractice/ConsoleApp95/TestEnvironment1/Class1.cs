using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp95
{
    [TestFixture]
    public class Class1
    {
        Count szotar = new Count();

        [TestCase("a")]
        public void IsSingleAEquelToNumberOfAs(string word)
        {
            Assert.AreEqual(1, szotar.LetterCounter(word)[word[0]]);
        }
    }
}