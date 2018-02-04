using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Payment
    {

        private int numOfPayments;
        private double amount;
        private double interest;
        private double total;        

        public Payment(int v1, double v2, double v3, double v4)
        {
            this.numOfPayments = v1;
            this.amount = v2;
            this.interest= v3;
            this.total = v4;
        }

        public int getNumOfPayments()
        {
            return numOfPayments;
        }
        public void setNumOfPayments(int numOfPayments)
        {
            this.numOfPayments = numOfPayments;
        }
        public double getAmount()
        {
            return amount;
        }
        public void setAmount(double amount)
        {
            this.amount = amount;
        }
        public double getInterest()
        {
            return interest;
        }
        public void setInterest(double interest)
        {
            this.interest = interest;
        }
        public double getTotal()
        {
            return total;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }
    }
}
