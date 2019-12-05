using System;
using System.Collections.Generic;

namespace FoodHazardAnalysis.Models
{
    public partial class Products
    {
        public Products()
        {
            ProductAdditives = new HashSet<ProductAdditives>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Protein { get; set; }
        public string Fats { get; set; }
        public string Carbohydrates { get; set; }
        public string Calories { get; set; }
        public string Composition { get; set; }

        public ICollection<ProductAdditives> ProductAdditives { get; set; }
    }
}
