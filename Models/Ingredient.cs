using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKiosk.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public required string? Name { get; set; }
        public required string? QuantityDescription { get; set; }
        public required decimal UnitPrice { get; set; }
        public required string? AlergensList { get; set; }
    }
}