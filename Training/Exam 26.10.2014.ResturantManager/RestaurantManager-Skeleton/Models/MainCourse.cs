using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    internal class MainCourse:Meal,IMainCourse
    {
        private readonly MainCourseType type;
        public MainCourse(string name,decimal price,int calories,int quantity,int time,bool isVegan,MainCourseType type):base(name,price,calories,quantity,time,isVegan)
        {
            this.type = type;
        }
        public MainCourseType Type { get { return this.type; } }

    }
}
