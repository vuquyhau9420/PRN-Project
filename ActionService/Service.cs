using BusinessObject;
using DataObjects;
using DataObjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService {
    public class Service : IService {

        static readonly IStaffDao staffDao = StaffDao.GetInstance();
        static readonly ICategoryDao categoryDao = CategoryDao.GetInstance();
        static readonly IProductGroupDao productGroupDao = ProductGroupDao.GetInstance();
        static readonly IProductDao productDao = ProductDao.GetInstance();

        #region Login
        public Staff CheckLogin(string username, string password) {
            return staffDao.CheckLogin(username, password);
        }
        #endregion

        #region Category
        public List<Category> GetCategories() {
            return categoryDao.GetCategories();
        }
        #endregion

        #region Product_Group
        public List<ProductGroup> GetProductGroups(int category_id) {
            return productGroupDao.GetProductGroups(category_id);
        }
        #endregion

        #region Product
        public List<Product> GetProducts(string productGroupId) {
            return productDao.GetProducts(productGroupId);
        }

        public bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            return productDao.UpdateProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }

        public bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            return productDao.InsertProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }

        public bool DeleteProduct(string productId) {
            return productDao.DeleteProduct(productId);
        }
        #endregion
    }
}
