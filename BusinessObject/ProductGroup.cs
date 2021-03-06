﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    public class ProductGroup : BusinessObject {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SupplierName { get; set; }
        public string ProductGroupCategory { get; set; }
        public bool IsStocking { get; set; }
        public bool Status { get; set; }

        // Parent
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}
