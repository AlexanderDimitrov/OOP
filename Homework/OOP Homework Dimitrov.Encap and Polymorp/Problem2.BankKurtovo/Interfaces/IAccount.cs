using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BankKurtovo.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Ballance { get; }

        double InterestRate { get; }

        decimal CalculateIntereset(int months);
    }
}
