using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BankKurtovo.Prop
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
            this.DepositRateMinDuration = 2;
            this.MortgageRateMinDuration = 12;
        }
    }
}
