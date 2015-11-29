using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Interfaces;

namespace Problem_3.Company.Employe
{
    class Developer:Employee,IDeveloper
    {
        public Developer(int id, string name, string lastName, decimal salary, string department, List<Project> projects) : base(id, name, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} {1} Id: {2} \n\rSalary: {3}\n\rDepartment: {4}\n\rProjects:\n\r", this.Name, this.LastName, this.ID, this.Salary, this.Department);
            foreach (var project in this.Projects)
            {
                print.AppendLine(project.ToString());
            }

            return print.ToString();
        }
    }
}
