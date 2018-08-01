using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Anagrams()
        {
            Program prog = new Program ();
            bool newBool = Program.IsAnagram("apple", "appel");
            Assert.True(newBool);
        }
    }
}