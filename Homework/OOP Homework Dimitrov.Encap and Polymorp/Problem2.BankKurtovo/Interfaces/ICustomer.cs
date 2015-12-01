using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BankKurtovo.Interfaces
{
    public interface ICustomer
    {
        string Name { get; }

        int DepositRateMinDuration { get; }

        int MortgageRateMinDuration { get; }
    }
}
