using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //Get the things you are testing ready. Things like creating istances of objects
            //Creating test variables to test against the thing you are testing and so on
            testClass objtest = new testClass();
            Boolean result;

            //Act
            //Running the testing part of the test, comparing variables, objects and other things
            //Checking if a variable runs or becomes true and things like that
            //Testing if a bit of code is dead code or not, and so on
            result = objtest.testFunction();

            //Assert
            //Assesing the results, and checking if the results are equal to what you were expecting
            //If not, adjust your expectation or change the code so it gives you the result you need
            Assert.AreEqual(true, result);
        }
    }
}
