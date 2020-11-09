using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    interface IProductGroupView : IView {
        string GroupId { get; }
        string ProductGroupName { get; }
        int ProductGroupSupplier { get; }
        int ProductGroupCategory { get; }
        bool IsStocking { get; }
        bool Status { get; }
    }
}
