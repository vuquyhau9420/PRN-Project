using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IProductDao {
        List<Product> GetAllProducts(string productGroupId);

        List<Product> GetProductsActive(string productGroupId);

        Product GetProduct(string productId);

        bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);

        bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);

        bool DeleteProduct(string productId);

        int GetQuantity(string productId);
    }
}
