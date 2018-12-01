using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestHello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCName()
        {
            //Arrange  
            HelloConsole.ClsAdd Ica = new HelloConsole.ClsAdd();
            String firstName = "Narasimha";
            String lastName = "Reddy";
            String expected = "Narasimha Reddy";
            String actual;
            //Act  
            actual = Ica.AddName(firstName, lastName);
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}
