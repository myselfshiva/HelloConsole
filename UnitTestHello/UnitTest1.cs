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
            String firstName = "Vinita";
            String lastName = "Singh";
            String expected = "Vinita Sing";
            String actual;
            //Act  
            actual = Ica.AddName(firstName, lastName);
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}
