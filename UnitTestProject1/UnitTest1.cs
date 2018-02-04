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
            Mock<BanqServiceClass> mockBanqServiceClass = new Mock<BanqServiceClass>();
            MockData mdt = new MockData();
            mockBanqServiceClass.Setup(r => r.GetLoanTypes()).Returns(mdt.getAllLoansList);
            BanqServiceClass banqServiceClass = new BanqServiceClass();
            List<LoanType> ltypes = mockBanqServiceClass.Object.GetLoanTypes();
            Assert.AreEqual(ltypes.Count, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Mock<Utility> mockUtil = new Mock<Utility>();
            //MockData mdt = new MockData();
            //mockUtil.Setup(r => r.GetLoanTypes()).Returns(mdt.getAllLoansList);            
            //BanqServiceClass banqServiceClass = new BanqServiceClass();
            //List<LoanType> ltypes = banqServiceClass.GetLoanTypes(mockUtil.Object);
            //Assert.AreEqual(ltypes.Count, 2);
        }        
    }
}
