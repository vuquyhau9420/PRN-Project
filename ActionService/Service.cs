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
        static readonly ISupplierDao supplierDao = SupplierDao.GetInstance();

        #region Login
        public Staff CheckLogin(string username, string password) {
            return staffDao.CheckLogin(username, password);
        }
        #endregion

        #region Category
        public List<Category> GetAllCategories() {
            return categoryDao.GetAllCategories();
        }
        #endregion

        #region Product_Group
        public List<ProductGroup> GetAllProductGroups(int category_id) {
            return productGroupDao.GetAllProductGroups(category_id);
        }

        public bool CheckStocking(string product_group_id) {
            return productGroupDao.CheckStocking(product_group_id);
        }

        public bool UpdateStocking(string product_group_id, bool status) {
            return productGroupDao.UpdateStocking(product_group_id, status);
        }
        #endregion

        #region Product
        public List<Product> GetAllProducts(string productGroupId) {
            return productDao.GetAllProducts(productGroupId);
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
        #region Supplier
        public List<Supplier> GetAllSuppliers() {
            return supplierDao.GetAllSuppliers();
        }

        public List<Supplier> GetSuppliersActive() {
            return supplierDao.GetSuppliersActive();
        }
        #endregion

        public List<Staff> GetAllStaff()
        {
            return staffDao.GetStaffs();
        }
    }
}
