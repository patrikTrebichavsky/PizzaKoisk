using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKiosk.Model
{
    public class Order
    {
        public int Id { get; set; }
        public OrderStatusType Staus { get; set; }
        public FulfillmentOptionType FulfillmentOption { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<OrderedPizza> OrderedPizzas { get; set; }


    }
}
