﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    interface IProductGroupView : IView {
        string Id { get; }
        string Name { get; }
        string SupplierName { get; }
        string ProductGroupCategory { get; }
        bool IsStocking { get; }
        bool Status { get; }
    }
}
