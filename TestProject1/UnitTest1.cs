using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Hello from ClassLibrary2", new ClassLibrary2.Class1().SayHello());
        }
    }
}