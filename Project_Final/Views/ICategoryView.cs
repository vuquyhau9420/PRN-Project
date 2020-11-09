using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Views {
    interface ICategoryView : IView {
        int CategoryId { get; }
        string CategoryName { get; }
        bool Status { get; }
    }
}
