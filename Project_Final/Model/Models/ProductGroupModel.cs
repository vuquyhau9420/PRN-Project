using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    public class ProductGroupModel {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SupplierName { get; set; }
        public string ProductGroupCategory { get; set; }
        public bool IsStocking { get; set; }
        public IList<ProductModel> ListProducts { get; set; }

        // Parent 
        public SupplierModel Supplier { get; set; }
        public CategoryModel Category { get; set; }
    }
}
