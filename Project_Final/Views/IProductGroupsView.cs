﻿using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    public interface IProductGroupsView : IView {
        IList<ProductGroupModel> ProductGroups { get; set; }
    }
}
