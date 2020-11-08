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
        List<ProductGroup> GetProductGroupsActiveBaseCategory(int categoryId);
        List<ProductGroup> GetAllProductGroupsBaseCategory(int categoryId);
        List<ProductGroup> GetProductGroupsActiveBaseSupplier(int supplierId);
        List<ProductGroup> GetAllProductGroupsBaseSupplier(int supplierId);
        bool CheckStocking(string productGroupId);
        bool UpdateStocking(string productGroupId, bool status);
        bool InsertProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status);
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
    }
}
