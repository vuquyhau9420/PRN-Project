using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    public interface IProductView : IView {
        string GroupId { get; }
        string ProductID { get; }
        string ProductName { get; }
        int Quantity { get; }
        double ImportPrice { get; }
        double SalePrice { get; }
        string Description { get; }
        string ProductImage { get; }
        bool Status { get; }
    }
}
