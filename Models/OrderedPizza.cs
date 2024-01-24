using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKiosk.Model
{
    public class OrderedPizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string? Name { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<OrderedIngredient> OrderedIngredients { get; set; }

    }
}
