using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    internal class Drink:Recipe, IDrink
    {
        private readonly bool isCarbonated;

        public Drink(string name,decimal price,int calories,int quantity,int timee,bool isCarbonated):base(name,price,calories,quantity,MetricUnit.Milliliters,timee)
        {
            if (calories > 100)
            {
                throw new ArgumentException("Calories should not be more than 100");
            }
            if(timee>20)
            {
                throw new InvalidOperationException("Too long to prepare");
            }
            this.isCarbonated = isCarbonated;
        }
        public bool IsCarbonated { get {return this.isCarbonated; }}
    }
}
