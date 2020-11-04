using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IProductDao {
        List<Product> GetProducts(string productGroupId);

        Product GetProduct(string productId);

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);

        int GetQuantity(string productId);
    }
}
