using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab4ZadDom.Models
{
    /// <summary>
    /// View Model posiłku
    /// </summary>
    public class MealViewModel
    {

        public MealViewModel(string mealName, string ingredients, string description, decimal price, string photo)
        {
            MealName = mealName;
            Ingredients = ingredients;
            Description = description;
            Price = price;
            Photo = photo;
        }

        /// <summary>
        /// Nazwa dania
        /// </summary>
        public string MealName { get; set; }

        /// <summary>
        /// Lista składników w postaci stringa
        /// </summary>
        public string Ingredients { get; set; }

        /// <summary>
        /// Opis dania w postaci string
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Cena dania
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Ściezka do zdjęcia poglądowego
        /// </summary>
        public string Photo { get; set; }
    }
  


}


