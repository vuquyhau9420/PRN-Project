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
        List<ProductGroupModel> GetProductGroupsActiveBaseCategory(int category_id);
        List<ProductGroupModel> GetAllProductGroupsBaseCategory(int category_id);
        List<ProductGroupModel> GetProductGroupsActiveBaseSupplier(int supplier_id);
        List<ProductGroupModel> GetAllProductGroupsBaseSupplier(int supplier_id);
        bool CheckStocking(string product_group_id);
        bool UpdateStocking(string product_group_id, bool status);
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
