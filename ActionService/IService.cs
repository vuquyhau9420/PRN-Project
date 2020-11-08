using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService {
    interface IService {
        // Login
        Staff CheckLogin(string username, string password);

        #region Category
        List<Category> GetAllCategories();
        #endregion

        #region Product_Group
        List<ProductGroup> GetAllProductGroups(int category_id);
        bool CheckStocking(string product_group_id);
        bool UpdateStocking(string product_group_id, bool status);
        #endregion

        #region Product
        List<Product> GetAllProducts(string productGroupId);
        bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);
        bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);
        bool DeleteProduct(string productId);
        #endregion

        #region Supplier
        List<Supplier> GetAllSuppliers();
        List<Supplier> GetSuppliersActive();
        #endregion

        List<Staff> GetAllStaff();
    }
}
