using System;

class Person
{
    private string name;
    private int years;
    private string email;


    public string Name
    {
        get { return this.name; }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name shouldn't be empty");
            }
            this.name = value;
        }
    }
    public int Years
    {
        get
        {
            return this.years;
        }
        set
        {
            if (value < 1||value > 100)
            {
                throw new ArgumentOutOfRangeException("Age is between 1 and 100 years");
            }
            this.years = value;
        }
    }
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value == "" || !value.Contains("@"))

            {

                throw new ArgumentException("Invalid email!");

            }
            else
            {
                this.email = value;
            }
        }
    }
    //First Constructor Declare
    public Person(string name, int years,string email)
    {
        this.Name = name;
        this.Years = years;
        this.Email = email;
    }
    //Second Constructor Declare
    public Person(string name, int years) : this(name, years, null) { }

    public override string ToString()
    {
        return string.Format("Name:{0}, Age:{1},Email:{2}",
            this.name ,this.years,
            string.IsNullOrEmpty(this.email) ? "No email" : this.email);
    }
}



