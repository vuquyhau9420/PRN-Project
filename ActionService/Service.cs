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

        static readonly IStaffDao staffDao = new StaffDao();
        static readonly ICategoryDao categoryDao = new CategoryDao();
        static readonly IProductGroupDao productGroupDao = new ProductGroupDao();
        static readonly IProductDao productDao = new ProductDao();

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
        #endregion
    }
}
