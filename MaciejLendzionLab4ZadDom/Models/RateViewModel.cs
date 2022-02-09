using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab4ZadDom.Models
{
    public class RateViewModel
    {
        public RateViewModel()
        {

        }
        public RateViewModel(string name, string opinion)
        {
            this.Name = name;
            this.Opinion = opinion;
        }
        /// <summary>
        /// Nazwa wystawiającego opinie
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Treść opini
        /// </summary>
        public string Opinion { get; set; }

    }
}
