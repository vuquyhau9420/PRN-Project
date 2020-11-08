using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    class ProductGroupPresenter : Presenter<IProductGroupView> {
        public ProductGroupPresenter(IProductGroupView view) : base(view) {

        }

        public bool CheckStocking() {
            string product_group_id = View.Id;
            return Model.CheckStocking(product_group_id);
        }

        public bool UpdateStocking() {
            string product_group_id = View.Id;
            bool status = View.Status;
            return Model.UpdateStocking(product_group_id, status);
        }
    }
}
