namespace AnimalFarm
{
    using System;

    public abstract class Animal
    {
        private const int MinAnimalAge = 0;
        private const int MaxAnimalAge = 15;

        private string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string Name { get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Name shouldnt be empty");
                }
                if(string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentNullException("No white spots please");
                }
                this.name = value;
           }
        }
       
        private int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range[0...50].");
                }
                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
            
            
        }

        public abstract Product ProduceProduct();

        private double CalculateProductPerDay()
        {
            switch (this.age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}

