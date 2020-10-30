using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    class ProductGroupModel {
        public string Id { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public int ProductGroupCategory { get; set; }

        // Parent 
        public SupplierModel Supplier { get; set; }
        public CategoryModel Category { get; set; }
    }
}
