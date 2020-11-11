using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Viking_Rejser_Eksamen;
using Viking_Rejser_Eksamen.View;
using Viking_Rejser_Eksamen.ViewModel;
using Viking_Rejser_Eksamen.Model;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1(NyKunde window, MainWindow mainWindow)
        {
            //Arrange
            NyKundeViewModel viewModel;
            viewModel = new NyKundeViewModel(window, mainWindow);

            //Act            
            viewModel.NewCustomer2("Shano","idk","21212121");
            viewModel.NewCustomer2("Shano", "idk", "21212121");

            //Assert
            Assert.Fail();
        }
    }
}
