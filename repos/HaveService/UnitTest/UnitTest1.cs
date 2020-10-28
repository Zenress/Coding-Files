using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HaveService;
using System.Windows;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int id = 1;
            IstandsættelseInsertPage newObj = new IstandsættelseInsertPage(id);            
            Boolean result;

            //Act           
            result = newObj.hasSucceeded;

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
