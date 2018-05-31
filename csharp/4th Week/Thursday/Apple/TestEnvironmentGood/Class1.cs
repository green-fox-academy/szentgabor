using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apples;

namespace TestEnvironmentGood
{
    [TestFixture]
    public class Class1
    {
        // GetApples green = new GetApples;

        [Test]
        public void Apples()
        {
            Assert.AreEqual(GetApples.GetApple(), "apple");
        }
    }
}
