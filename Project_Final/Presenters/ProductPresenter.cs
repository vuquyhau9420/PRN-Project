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
            string productGroupId = View.ProductGroupId;
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
    }
}
