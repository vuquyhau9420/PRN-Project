using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    class OrderDetailModel {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }

        // Parent
        public OrderModel Order { get; set; }
        public ProductModel Product { get; set; }
    }
}
