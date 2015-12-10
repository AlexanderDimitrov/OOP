using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    internal class Dessert:Meal,IDessert
    {
        
        public Dessert(string name,decimal price,int calories,int quantity,int time,bool isVegan,bool withSugar):base(name,price,calories,quantity,time,isVegan)
        {
            this.WithSugar = withSugar;
        }
        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

    }
}
