using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKiosk.Model
{
    public class OrderedIngredient
    {

        public int Id { get; set; }
        public int OrderedPizzaId { get; set; }
        public string? Name { get; set; }
        public string? QuantityDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDecimal { get; set; }
        public int FreeQuantity { get; set; }
        public int PaidQuantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
