using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IserviceInterface
    {
        double GetInterest(int LoanType);
        List<LoanType> GetLoanTypes();
        List<Payment> ReturnPayment(double TotalAmount, int NumberOfYears, double Interest);       
    }
    public class ServiceClass : IserviceInterface
    {
        public virtual double GetInterest(int LoanType)
        {
            return 0.0;
        }

        public virtual  List<LoanType> GetLoanTypes()
        {
            return null;
        }

        public virtual List<Payment> ReturnPayment(double TotalAmount, int NumberOfYears, double Interest)
        {
            return null;
        }
    }
}
