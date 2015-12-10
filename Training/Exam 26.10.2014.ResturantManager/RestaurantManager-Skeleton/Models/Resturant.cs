using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    using Interfaces;
    public class Resturant:IRestaurant
    {
        private readonly string location;
        private readonly string name;
        public Resturant(string name,string location)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name is Required");
            }
            if(string.IsNullOrEmpty(location))
            {
                throw new ArgumentException("The location is required");
            }
            this.name = name;
            this.location = location;
            this.Recipes = new List<IRecipe>();
           
        }
        public string Name { get { return this.name; } }
        public string Location { get { return this.location; } }
        public IList<IRecipe> Recipes { get; private set; }
        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }
        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }
        public string PrintMenu()
        {
            var result = new StringBuilder();
            result.AppendFormat("***** {0} - {1} *****", this.Name, this.Location);
            if (!this.Recipes.Any())
            {
                result.AppendLine().Append("No recipes... yet");
            }
            else
            {
                var drinks = this.Recipes.Where(x => x is IDrink).OrderBy(x => x.Name);
                if (drinks.Any())
                {
                    result.AppendLine().Append("~~~~~ DRINKS ~~~~~");

                    foreach (IDrink item in drinks)
                    {
                        result.AppendLine().AppendFormat("==  {0} == ${1:0.00}", item.Name, item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} ml, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                        result.AppendLine().AppendFormat("Carbonated: {0}", item.IsCarbonated ? "yes" : "no");
                    }
                }

                var salads = this.Recipes.Where(x => x is ISalad).OrderBy(x => x.Name);
                if (salads.Any())
                {
                    result.AppendLine().Append("~~~~~ SALADS ~~~~~");

                    foreach (ISalad item in salads)
                    {
                        result.AppendLine()
                            .AppendFormat(
                                "{0}==  {1} == ${2:0.00}",
                                item.IsVegan ? "[VEGAN] " : string.Empty,
                                item.Name,
                                item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} g, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                        result.AppendLine().AppendFormat("Contains pasta: {0}", item.ContainsPasta ? "yes" : "no");
                    }
                }

                var mainCourses = this.Recipes.Where(x => x is IMainCourse).OrderBy(x => x.Name);
                if (mainCourses.Any())
                {
                    result.AppendLine().Append("~~~~~ MAIN COURSES ~~~~~");

                    foreach (IMainCourse item in mainCourses)
                    {
                        result.AppendLine()
                            .AppendFormat(
                                "{0}==  {1} == ${2:0.00}",
                                item.IsVegan ? "[VEGAN] " : string.Empty,
                                item.Name,
                                item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} g, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                        result.AppendLine().AppendFormat("Type: {0}", item.Type.ToString());
                    }
                }

                var desserts = this.Recipes.Where(x => x is IDessert).OrderBy(x => x.Name);
                if (desserts.Any())
                {
                    result.AppendLine().Append("~~~~~ DESSERTS ~~~~~");

                    foreach (IDessert item in desserts)
                    {
                        result.AppendLine()
                            .AppendFormat(
                                "{0}{1}==  {2} == ${3:0.00}",
                                item.WithSugar ? string.Empty : "[NO SUGAR] ",
                                item.IsVegan ? "[VEGAN] " : string.Empty,
                                item.Name,
                                item.Price);
                        result.AppendLine()
                            .AppendFormat("Per serving: {0} g, {1} kcal", item.QuantityPerServing, item.Calories);
                        result.AppendLine().AppendFormat("Ready in {0} minutes", item.TimeToPrepare);
                    }
                }
            }

            return result.ToString();
        }

    }
}
