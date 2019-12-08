using System;
using System.Collections.Generic;

namespace FoodHazardAnalysis.Models
{
    public partial class ProductAdditives
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? EadditiveId { get; set; }

        public Eadditives Eadditive { get; set; }
        public Products Product { get; set; }

        public FoodHazardBotDBContext FoodHazardBotDBContext
        {
            get => default(FoodHazardBotDBContext);
            set
            {
            }
        }
    }
}
