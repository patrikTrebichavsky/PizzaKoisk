using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PizzaKiosk.Model
{
    [Keyless]
    public class PizzaIngredient
    {
        public required int PizzaID { get; set; }
        public required int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }
        public Pizza? Pizza { get; set; }
        public required int MinimalQuantity { get; set; }
        public required int FreeQuantity { get; set; }
    }
}
