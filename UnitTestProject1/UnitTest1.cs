using ConsoleApp1;
using ConsoleApp1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Mock<ServiceClass> serviceClass = new Mock<ServiceClass>();
            MockData mdt = new MockData();
            serviceClass.Setup(r => r.GetLoanTypes()).Returns(mdt.getAllLoansList);            
            List<LoanType> ltypes = serviceClass.Object.GetLoanTypes();
            Assert.AreEqual(ltypes.Count, 2);
        }        
    }
}
