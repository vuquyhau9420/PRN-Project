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
        public List<ProductGroup> GetProductGroupsActiveBaseCategory(int categoryId) {
            return productGroupDao.GetProductGroupsActiveBaseCategory(categoryId);
        }

        public List<ProductGroup> GetAllProductGroupsBaseCategory(int categoryId) {
            return productGroupDao.GetAllProductGroupsBaseCategory(categoryId);
        }

        public List<ProductGroup> GetProductGroupsActiveBaseSupplier(int supplierId) {
            return productGroupDao.GetProductGroupsActiveBaseSupplier(supplierId);
        }

        public List<ProductGroup> GetAllProductGroupsBaseSupplier(int supplierId) {
            return productGroupDao.GetAllProductGroupsBaseSupplier(supplierId);
        }
        public bool CheckStocking(string productGroupId) {
            return productGroupDao.CheckStocking(productGroupId);
        }

        public bool UpdateStocking(string productGroupId, bool status) {
            return productGroupDao.UpdateStocking(productGroupId, status);
        }

        public bool InsertProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status) {
            return productGroupDao.InsertProductGroup(productGroupId, productGroupName, supplierId, categoryId, isStocking, status);
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
    }
}
