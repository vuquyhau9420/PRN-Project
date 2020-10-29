using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    class ProductGroup : BusinessObject {
        public string Id { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public int ProductGroupCategory { get; set; }
        public bool IsStocking { get; set; }
        public bool Status { get; set; }

        // Parent
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}
