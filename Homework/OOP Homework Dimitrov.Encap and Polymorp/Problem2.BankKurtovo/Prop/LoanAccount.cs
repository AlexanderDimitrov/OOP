using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BankKurtovo.Prop
{
    using Interfaces;

    public class LoanAccount : AccountBase
    {
        public LoanAccount(ICustomer customer, decimal ballance, double interesetrate)
            : base(customer, ballance, interesetrate)
        {
        }

        public override decimal CalculateIntereset(int months)
        {
            if (months <= this.Customer.DepositRateMinDuration)
            {
                return this.Ballance;
            }

            return base.CalculateIntereset(months - this.Customer.DepositRateMinDuration);
        }
    }

}
