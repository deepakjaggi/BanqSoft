﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class LoanType
    {
        public int loanType;
        public String loanText;
        public int getLoanType()
        {
            return loanType;
        }
        public void setLoanType(int loanType)
        {
            this.loanType = loanType;
        }
        public String getLoanText()
        {
            return loanText;
        }
        public void setLoanText(String loanText)
        {
            this.loanText = loanText;
        }
    }
}