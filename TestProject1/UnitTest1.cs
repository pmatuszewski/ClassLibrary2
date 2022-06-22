using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    
    [TestClass]
    public class Tests
    {

        
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("Hello from ClassLibrary2", new ClassLibrary2.Class1().SayHello());
        }
    }
}
