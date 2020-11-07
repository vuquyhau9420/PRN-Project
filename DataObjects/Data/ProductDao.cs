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

        private static ProductDao instance;

        public static ProductDao GetInstance() {
            if (instance == null) {
                instance = new ProductDao();
            }
            return instance;
        }

        static DBHelpers db = new DBHelpers();
        public bool DeleteProduct(string productId) {
            string storeProcedure = "spDeleteProduct";
            object[] parms = { "@PRODUCT_ID", productId };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
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

        public bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            string storeProcedure = "spInsertProduct";
            object[] parms = { "@PRODUCT_GROUP_ID", productGroupId, "@PRODUCT_ID", productId, "@PRODUCT_NAME", productName,
                               "@PRODUCT_QUANTITY", quantity, "@PRODUCT_IMPORT_PRICE", importPrice,
                               "@PRODUCT_SALE_PRICE", salePrice, "@PRODUCT_DESCRIPTION", description,
                               "@PRODUCT_IMAGE", image, "@PRODUCT_STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            string storeProcedure = "spUpdateProduct";
            object[] parms = { "@PRODUCT_GROUP_ID", productGroupId, "@PRODUCT_ID", productId, "@PRODUCT_NAME", productName,
                               "@PRODUCT_QUANTITY", quantity, "@PRODUCT_IMPORT_PRICE", importPrice,
                               "@PRODUCT_SALE_PRICE", salePrice, "@PRODUCT_DESCRIPTION", description,
                               "@PRODUCT_IMAGE", image, "@PRODUCT_STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
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
