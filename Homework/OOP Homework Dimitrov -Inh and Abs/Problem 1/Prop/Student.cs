using System;
using System.Text.RegularExpressions;



namespace Problem1.Prop
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName,string secondName,string facultyNumber) :base(firstName,secondName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if(value.Length< 5 || value.Length >10)
                {
                    throw new ArgumentOutOfRangeException("Faculty Number should be range from [5..10]");
                }
                if(IsInvalid(value))
                {
                    throw new ArgumentException("Faculty Number should contain only digits and letters.");
                }
                this.facultyNumber = value;
            }
        }
        
        private bool IsInvalid(string value)
        {
            Regex regex = new Regex("^a-0z-Z0-9");
            if (regex.IsMatch(value))
            {
                return true;
            }

            return false;

        }
    }
}
