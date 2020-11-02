using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    public class ProductGroupPresenter : Presenter<IProductGroupView> {

        public ProductGroupPresenter(IProductGroupView view) : base(view) {

        }

        public void Display(int category_id) {
            View.ProductGroups = Model.GetProductGroups(category_id);
        }
    }
}
