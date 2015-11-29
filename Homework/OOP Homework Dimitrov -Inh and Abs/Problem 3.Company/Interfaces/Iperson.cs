using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Company.Interfaces
{
    interface IPerson
    {
        int ID { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
    }
}
