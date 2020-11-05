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
        public void Display(string productGroupId) {
            View.Products = Model.GetProducts(productGroupId);
        }

        public bool Update(ProductModel product) {
            return Model.UpdateProduct(product);
        }
    }
}
