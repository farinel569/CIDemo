using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CIDemoTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            var result = CIDemo.Program.Main(new[] {"foo","foo"});
            Assert.AreEqual(1,result);
       
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = CIDemo.Program.Main(new[] {"fooo","foo"});
            Assert.AreEqual(0,result);

        }

    }
}
