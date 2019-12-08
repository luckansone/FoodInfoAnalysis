using System;
using System.Collections.Generic;

namespace FoodHazardAnalysis.Models
{
    public partial class Eadditives
    {
        public Eadditives()
        {
            ProductAdditives = new HashSet<ProductAdditives>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Category { get; set; }
        public string Danger { get; set; }
        public string FullName { get; set; }

        public ICollection<ProductAdditives> ProductAdditives { get; set; }

        public FoodHazardBotDBContext FoodHazardBotDBContext
        {
            get => default(FoodHazardBotDBContext);
            set
            {
            }
        }
    }
}
