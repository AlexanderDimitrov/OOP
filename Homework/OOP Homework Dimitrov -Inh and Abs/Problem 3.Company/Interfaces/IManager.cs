using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Employe;

namespace Problem_3.Company.Interfaces
{
    interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
