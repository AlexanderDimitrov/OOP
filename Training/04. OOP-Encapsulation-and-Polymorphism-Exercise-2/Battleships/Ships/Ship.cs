using System;
namespace Battleships.Ships
{
    public abstract class Ship
    {
        private string name;
        private double lenghtInMetters;
        private double volume;
        public Ship(string name,double lenghtInMetters,double volume,bool IsDestroyed)
        {
            this.Name = name;
            this.LenghtInMetters = lenghtInMetters;
            this.Volume = volume;
            this.IsDestroyed = IsDestroyed;
            
        }
        public double LenghtInMetters
        {
            get { return this.lenghtInMetters; }
            set
            {
                if (value < 0 || value > 2000)
                {
                    throw new ArgumentOutOfRangeException("Lenght must be in range 0...50");
                }
                this.lenghtInMetters = value;
            }
        }
        public double Volume
        {
            get { return this.volume; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative");
                }
                this.volume = value;
                
            }
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                //if (string.IsNullOrEmpty(name))
                //{
                  //  throw new ArgumentNullException("Name shouldnt be empty");
                //}
                this.name = value;
                
            }
        }

        
        public bool IsDestroyed { get; set; }
    }
}
