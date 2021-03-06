﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    public class CategoryModel {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public IList<ProductGroupModel> ProductGroups { get; set; }
    }
}
