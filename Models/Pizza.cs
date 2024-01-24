using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKiosk.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public required string? Name { get; set; }
        public required string? Description { get; set; }
        public required decimal Price { get; set; }
        public required bool IsAvailable { get; set; }
        public required string? AlergensList { get; set; }
    }
}
