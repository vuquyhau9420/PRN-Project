using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    class Product : BusinessObject {
        public string ProductGroupId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double ImportPrice { get; set; }
        public double SalePrice { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        // Parent
        public ProductGroup ProductGroup { get; set; }
    }
}
