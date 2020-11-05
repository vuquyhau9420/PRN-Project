using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data {
    public class ProductDao : IProductDao {

        static DBHelpers db = new DBHelpers();
        public void DeleteProduct(Product product) {
            throw new NotImplementedException();
        }

        public Product GetProduct(string productId) {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(string productGroupId) {
            string storeProcedure = "spGetProducts";
            object[] parms = { "@PRODUCT_GROUP_ID", productGroupId };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public int GetQuantity(string productId) {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product product) {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product) {
            throw new NotImplementedException();
        }

        static Func<IDataReader, Product> make = reader => new Product
        {
            ProductGroupId = reader["product_group_id"].AsString(),
            Id = reader["product_id"].AsString(),
            Name = reader["product_name"].AsString(),
            Quantity = reader["product_quantity"].AsInt(),
            ImportPrice = reader["product_import_price"].AsDouble(),
            SalePrice = reader["product_sale_price"].AsDouble(),
            Description = reader["product_description"].AsString(),
            Image = reader["product_image"].AsString(),
            Status = reader["product_status"].AsBoolean()
        };
    }
}
