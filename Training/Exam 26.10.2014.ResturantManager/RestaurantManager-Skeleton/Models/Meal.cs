using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    internal abstract class Meal :Recipe , IMeal
    {
        private bool isVegan;
        protected Meal(string name,decimal price,int calories,int quantity,int time,bool isVegan):base(name,price,calories,quantity,MetricUnit.Grams,time)
        {
            this.isVegan = isVegan;
        }
        public bool IsVegan { get { return this.isVegan; } }
        public void ToggleVegan()
        {
            this.isVegan = !this.isVegan;
        }
        
    }
}
