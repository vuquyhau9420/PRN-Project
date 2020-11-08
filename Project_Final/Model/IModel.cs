using BusinessObject;
using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model {
    public interface IModel {
        StaffModel Login(string username, string password);

        #region Category
        List<CategoryModel> GetAllCategories();
        #endregion

        #region Product Group
        List<ProductGroupModel> GetProductGroupsActiveBaseCategory(int categoryId);
        List<ProductGroupModel> GetAllProductGroupsBaseCategory(int categoryId);
        List<ProductGroupModel> GetProductGroupsActiveBaseSupplier(int supplierId);
        List<ProductGroupModel> GetAllProductGroupsBaseSupplier(int supplierId);
        bool CheckStocking(string productGroupId);
        bool UpdateStocking(string productGroupId, bool status);
        bool InsertProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status);
        #endregion

        #region Product
        List<ProductModel> GetAllProducts(string productGroupId);
        bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);
        bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);
        bool DeleteProduct(string productId);
        #endregion
        #region Supplier
        List<SupplierModel> GetAllSuppliers();
        List<SupplierModel> GetSuppliersActive();
        #endregion
    }
}
