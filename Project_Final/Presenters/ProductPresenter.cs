using Project_Final.Model.Models;
using Project_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Presenters {
    public class ProductPresenter : Presenter<IProductView> {

        public ProductPresenter(IProductView view) : base(view) {

        }

        public bool Update() {
            string productGroupId = View.GroupId;
            string productId = View.ProductID;
            string productName = View.ProductName;
            int quantity = View.Quantity;
            double importPrice = View.ImportPrice;
            double salePrice = View.SalePrice;
            string description = View.Description;
            string image = View.ProductImage;
            bool status = View.Status;
            return Model.UpdateProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }

        public bool Insert() {
            string productGroupId = View.GroupId;
            string productId = View.ProductID;
            string productName = View.ProductName;
            int quantity = View.Quantity;
            double importPrice = View.ImportPrice;
            double salePrice = View.SalePrice;
            string description = View.Description;
            string image = View.ProductImage;
            bool status = View.Status;
            return Model.InsertProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }

        public bool Delete() {
            string productId = View.ProductID;
            return Model.DeleteProduct(productId);
        }

        public bool CheckStocking() {
            string product_group_id = View.GroupId;
            return Model.CheckStocking(product_group_id);
        }

        public bool UpdateStocking(bool status) {
            string product_group_id = View.GroupId;
            return Model.UpdateStocking(product_group_id, status);
        }
    }
}
