using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_3.Company.Employe
{
    class RegularEmployee:Employee
    {
        public RegularEmployee(int id, string name, string lastName, decimal salary, string department):base(id,name,lastName,salary,department)
        {

        }
    }
}
