using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.Company.Interfaces;

namespace Problem_3.Company
{
    public abstract class Person : IPerson
    {
        private int id;
        private string name;
        private string lastName;
        public Person(int id, string name, string lastName)
        {
            this.ID = id;
            this.Name = name;
            this.LastName = lastName;
        }
        public int ID { get { return this.id; }
            set
            {
                if(value.ToString().Length !=8)
                {
                    throw new ArgumentException("ID should be 10 digits long.");
                }
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Name should be in range[1...10]Symbols");
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.name = value;

            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Name should be in range[1...10]Symbols");
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.lastName = value;

            }
        }
       
        


    }
}


