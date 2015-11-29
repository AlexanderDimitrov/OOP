using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Interfaces;


namespace Problem_3.Company.Employe
{
    class Employee:Person,IEmployee
    {
        private string department;
        private decimal salary;
        
        public Employee(int id,string name,string lastName,decimal salary,string department):base(id,name,lastName)
        {

        }
        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary Should be Positive");
                }
                this.salary = value;
            }
        }
        public string Department
        {
            get { return this.department; }
            set
            {
                if(value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new AggregateException("Invalid Department");
                }
                this.department = value;
            }
        }
        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("- {0} {1} Id: {2} \n\r  Salary: {3}\n\r  Department: {4}", this.Name, this.LastName, this.ID, this.Salary, this.Department);

            return print.ToString();
        }

    }
}
