using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    public class ProductGroupsPresenter : Presenter<IProductGroupsView> {

        public ProductGroupsPresenter(IProductGroupsView view) : base(view) {

        }

        public void DisplayBaseCategory(int category_id) {
            View.ProductGroups = Model.GetAllProductGroupsBaseCategory(category_id);
        }

        public void DisplayActiveGroupsBaseCategory(int category_id) {
            View.ProductGroups = Model.GetProductGroupsActiveBaseCategory(category_id);
        }

        public void DisplayBaseSupplier(int supplier_id) {
            View.ProductGroups = Model.GetAllProductGroupsBaseSupplier(supplier_id);
        }
    }
}
