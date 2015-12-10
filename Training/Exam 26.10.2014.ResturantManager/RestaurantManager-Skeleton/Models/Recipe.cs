using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    internal abstract class Recipe :IRecipe
    {
        private readonly int calories;
        private readonly string name;
        private readonly decimal price;
        private readonly int quantityPerServing;
        private readonly int timeToPrepare;
        private readonly MetricUnit unit;
                
        protected Recipe(string name, decimal price, int calories, int quantity, MetricUnit unit, int time)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name is required.");
            }

            if (price < 0 || calories < 0 || quantity < 0 || time < 0)
            {
                throw new InvalidOperationException("The <parameter> must be positive.");
            }

            this.name = name;
            this.price = price;
            this.calories = calories;
            this.quantityPerServing = quantity;
            this.unit = unit;
            this.timeToPrepare = time;
        }
        public int Calories { get { return this.calories; } }
        public string Name { get { return this.name; } }
        public decimal Price { get { return this.price; } }
        public int QuantityPerServing { get { return this.quantityPerServing; } }
        public int TimeToPrepare { get { return this.timeToPrepare; } }
        public MetricUnit Unit { get { return this.unit; } }

       


    }
}
