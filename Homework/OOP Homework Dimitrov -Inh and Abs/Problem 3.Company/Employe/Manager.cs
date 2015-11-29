using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Interfaces;

namespace Problem_3.Company.Employe
{
    class Manager:Employee,IManager
    {
        public Manager(int id,string name,string lastName,decimal salary,string department, List<Employee> employyees) :base(id,name,lastName,salary,department)
        {
            this.Employees = employyees;
        }
        public List<Employee> Employees
        {
            get; set;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} Id: {2} \n\rSalary: {3}\n\rDepartment: {4}\n\rEmployee:\n\r", this.Name, this.LastName, this.ID, this.Salary, this.Department);
            foreach (var project in this.Employees)
            {
                output.AppendLine(project.ToString());
            }

            return output.ToString();
        }
    }
}
