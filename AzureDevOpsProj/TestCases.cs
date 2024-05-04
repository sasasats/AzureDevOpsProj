using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDevOpsProj
{
    [TestFixture]
    public class TestCases
    {
        [Test]
        [Category("PassedTest")]
        public void TestToPass()
        {
            Assert.Pass();
        }

        [Test]
        [Category("FailedTest")]
        public void TestToFail()
        {
            Assert.Fail();
        }
    }
}
