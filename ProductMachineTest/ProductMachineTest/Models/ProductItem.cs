using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMachineTest.Models
{
    public class ProductItem
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string ProductId { get; set; }
        public float price { get; set; }
        public string Quantity { get; set; }
        public bool IsComplete { get; set; }

    }
}
