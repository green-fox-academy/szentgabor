using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumProject;

namespace Sum
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void PrintMessageTest()
        {
            Program program = new Program();
            List<int> testList = new List<int>() {7,3,5,9,9};
            Assert.AreEqual(program.SumReturner(testList), 33);
        }
    }
}