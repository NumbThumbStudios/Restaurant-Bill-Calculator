using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Bill_Calculator.Models
{
    public class MenuItem
    {
        // ----    INSTANCE VARIALBES    ---- //
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
