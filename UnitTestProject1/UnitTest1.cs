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
        public void tc001_VerifyGetLoanTypes()
        {
            Mock<ServiceClass> serviceClass = new Mock<ServiceClass>();
            MockData mdt = new MockData();
            serviceClass.Setup(r => r.GetLoanTypes()).Returns(mdt.getAllLoansList);            
            List<LoanType> ltypes = serviceClass.Object.GetLoanTypes();
            Assert.AreEqual(ltypes.Count, 2);
        }
        [TestMethod]
        public void tc002_VerifyGetInterestForHomeLoan()
        {
            Mock<ServiceClass> serviceClass = new Mock<ServiceClass>();
            MockData mdt = new MockData();
            serviceClass.Setup(r => r.GetInterest(1)).Returns(mdt.getInterestRate("Home Loan"));
            double interestRate = serviceClass.Object.GetInterest(1);
            Assert.AreEqual(3.14, interestRate);
        }
        [TestMethod]
        public void tc003_VerifyGetInterestForHomeLoan()
        {
            Mock<ServiceClass> serviceClass = new Mock<ServiceClass>();
            MockData mdt = new MockData();
            serviceClass.Setup(r => r.GetInterest(2)).Returns(mdt.getInterestRate("Car Loan"));
            double interestRate = serviceClass.Object.GetInterest(2);
            Assert.AreEqual(6.00, interestRate);
        }
        [TestMethod]
        public void tc004_VerifyGetInterestForCar()
        {
            Mock<ServiceClass> serviceClass = new Mock<ServiceClass>();
            MockData mdt = new MockData();
            serviceClass.Setup(r => r.GetInterest(2)).Returns(mdt.getInterestRate("Car Loan"));
            double interestRate = serviceClass.Object.GetInterest(2);
            Assert.AreEqual(6.00, interestRate);
        }
        [TestMethod]
        public void tc005_VerifyReturnPaymentServiceCorrectCaluclations()
        {
            Mock<ServiceClass> serviceClass = new Mock<ServiceClass>();
            MockData mdt = new MockData();
            serviceClass.Setup(r => r.ReturnPayment(1000.00, 1, 3.14)).Returns(mdt.returnPaymentsCalculationsFor3DigitAmount);
            List<Payment> paymentStruct = serviceClass.Object.ReturnPayment(1000.00, 1, 3.14);
            if (paymentStruct.ToString().Equals(mdt.returnPaymentsCalculationsFor3DigitAmount().ToString()))
            {
                Assert.AreEqual(true, true);
            }
            else
            {
                Assert.AreEqual(true, false);
            }
        }
    }
}
