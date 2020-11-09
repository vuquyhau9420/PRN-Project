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
            string productGroupId = View.GroupId;
            return Model.CheckStocking(productGroupId);
        }

        public bool UpdateStocking(bool status) {
            string productGroupId = View.GroupId;
            return Model.UpdateStocking(productGroupId, status);
        }

        public bool Insert() {
            string productGroupId = View.GroupId;
            string productGroupName = View.ProductGroupName;
            int supplierId = View.ProductGroupSupplier;
            int productGroupCategory = View.ProductGroupCategory;
            bool isStocking = View.IsStocking;
            bool status = View.Status;

            return Model.InsertProductGroup(productGroupId, productGroupName, supplierId, productGroupCategory, isStocking, status);
        }

        public bool Update() {
            string productGroupId = View.GroupId;
            string productGroupName = View.ProductGroupName;
            int supplierId = View.ProductGroupSupplier;
            int productGroupCategory = View.ProductGroupCategory;
            bool isStocking = View.IsStocking;
            bool status = View.Status;

            return Model.UpdateProductGroup(productGroupId, productGroupName, supplierId, productGroupCategory, isStocking, status);
        }

        public bool DeleteProducts() {
            string productGroupId = View.GroupId;
            return Model.DeleteProducts(productGroupId);
        }

        public bool Delete() {
            string productGroupId = View.GroupId;
            return Model.DeleteProductGroup(productGroupId);
        }
    }
}
