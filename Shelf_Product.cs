using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SmartShelfMonitor
{
    class Shelf_Product
    {
        public Shelf Shelf { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
    }
}