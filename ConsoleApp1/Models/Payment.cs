using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Payment
    {

        private int numOfPayments;
        private double amount;
        private double interest;
        private double total;

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
