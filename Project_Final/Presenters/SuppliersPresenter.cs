using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    class SuppliersPresenter : Presenter<ISuppliersView> {

        public SuppliersPresenter(ISuppliersView view) : base(view) {

        }

        public void Display() {
            View.Suppliers = Model.GetAllSuppliers();
        }
    }
}
