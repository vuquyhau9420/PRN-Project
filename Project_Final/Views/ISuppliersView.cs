﻿using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    interface ISuppliersView : IView {

        IList<SupplierModel> Suppliers { set; }
    }
}
