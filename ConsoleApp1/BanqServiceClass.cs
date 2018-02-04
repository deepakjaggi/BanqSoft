using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class BanqServiceClass
    {
        public BanqServiceClass()
        {

        }
        public double GetInterest(int LoanType)
        {
            return 0.0;
        }

        public virtual List<LoanType> GetLoanTypes()
        {
            return null;
        }

        public List<Payment> ReturnPayment(double TotalAmount, int NumberOfYears, double Interest)
        {
            return null;
        }
    }

    public class Utility
    {
        public virtual List<LoanType> GetLoanTypes()
        {
            return null;
        }

    }
}
