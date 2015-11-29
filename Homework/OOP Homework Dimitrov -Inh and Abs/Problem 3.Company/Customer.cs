using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Interfaces;

namespace Problem_3.Company
{
    class Customer : Person,ICustomer
    {
        private decimal totalAmount;
        public Customer(int id, string name, string lastName, decimal totalAmount) : base(id, name, lastName)
        {
            this.TotalAmount = totalAmount;
        }

        public decimal TotalAmount
        {
            get { return this.totalAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount cannot be negative.");
                }

                this.totalAmount = value;
            }
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} {1} Id: {2} \n\r", this.Name, this.LastName, this.ID);
            print.AppendFormat("Total Amount: {0}", this.TotalAmount);
            return print.ToString();
        }
    }
}
