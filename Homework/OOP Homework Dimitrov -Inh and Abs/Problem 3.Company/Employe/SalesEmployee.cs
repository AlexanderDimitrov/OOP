using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Interfaces;

namespace Problem_3.Company.Employe
{
    class SalesEmployee:Employee,ISalesEmployee
    {
        public SalesEmployee(int id, string name, string lastName, decimal salary, string department, List<Sale> sales) : base(id, name, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} Id: {2} \n\rSalary: {3}\n\rDepartment: {4}\n\rSales:n\r", this.Name, this.LastName, this.ID, this.Salary, this.Department);
            foreach (var project in this.Sales)
            {
                output.AppendLine(project.ToString());
            }

            return output.ToString();
        }
    }
}
