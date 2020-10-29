using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    class OrderDetail : BusinessObject {
        public string OrderId { get; set; }
        public int Id { get; set; }
        public string ProductId { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }

        // Parent
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
