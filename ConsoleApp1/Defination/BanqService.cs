using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Defination
{

    interface IBanqService
    {
        List<Payment> ReturnPayment(double TotalAmount, int NumberOfYears, double Interest);        
        double GetInterest(int LoanType);
        List<LoanType> GetLoanTypes();
    }

}
