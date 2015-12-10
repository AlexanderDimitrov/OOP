using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    internal class Salad:Meal,ISalad

    {
        private readonly bool saladType;
        public Salad(string name,decimal price,int calories,int quantity,int time,bool isVegan,bool saladType):base(name,price,calories,quantity,time,isVegan)
        {
            this.saladType = saladType;
        }
        public bool ContainsPasta { get { return this.saladType; } }

    }
}
