using ActionService;
using AutoMapper;
using BusinessObject;
using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model {
    public class Model : IModel {
        static Service service = new Service();

        static Model() {
            Mapper.CreateMap<Staff, StaffModel>();
            Mapper.CreateMap<StaffModel, Staff>();
            Mapper.CreateMap<Category, CategoryModel>();
            Mapper.CreateMap<ProductGroup, ProductGroupModel>();
            Mapper.CreateMap<Product, ProductModel>();
            Mapper.CreateMap<Supplier, SupplierModel>();
        }

        #region Login
        public StaffModel Login(string username, string password) {
            return Mapper.Map<Staff, StaffModel>(service.CheckLogin(username, password));
        }
        #endregion

        #region Category
        public List<CategoryModel> GetAllCategories() {
            return Mapper.Map<List<Category>, List<CategoryModel>>(service.GetAllCategories());
        }
        #endregion

        #region Product Group
        public List<ProductGroupModel> GetProductGroupsActiveBaseCategory(int categoryId) {
            return Mapper.Map<List<ProductGroup>, List<ProductGroupModel>>(service.GetProductGroupsActiveBaseCategory(categoryId));
        }

        public List<ProductGroupModel> GetAllProductGroupsBaseCategory(int categoryId) {
            return Mapper.Map<List<ProductGroup>, List<ProductGroupModel>>(service.GetAllProductGroupsBaseCategory(categoryId));
        }

        public List<ProductGroupModel> GetProductGroupsActiveBaseSupplier(int supplierId) {
            return Mapper.Map<List<ProductGroup>, List<ProductGroupModel>>(service.GetProductGroupsActiveBaseSupplier(supplierId));
        }

        public List<ProductGroupModel> GetAllProductGroupsBaseSupplier(int supplierId) {
            return Mapper.Map<List<ProductGroup>, List<ProductGroupModel>>(service.GetAllProductGroupsBaseSupplier(supplierId));
        }

        public bool CheckStocking(string productGroupId) {
            return service.CheckStocking(productGroupId);
        }

        public bool UpdateStocking(string productGroupId, bool status) {
            return service.UpdateStocking(productGroupId, status);
        }

        public bool InsertProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status) {
            return service.InsertProductGroup(productGroupId, productGroupName, supplierId, categoryId, isStocking, status);
        }
        #endregion

        #region Product
        public List<ProductModel> GetAllProducts(string productGroupId) {
            return Mapper.Map<List<Product>, List<ProductModel>>(service.GetAllProducts(productGroupId));
        }
        public bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            return service.UpdateProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }
        public bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            return service.InsertProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }
        public bool DeleteProduct(string productId) {
            return service.DeleteProduct(productId);
        }
        #endregion
        #region Supplier
        public List<SupplierModel> GetAllSuppliers() {
            return Mapper.Map<List<Supplier>, List<SupplierModel>>(service.GetAllSuppliers());
        }
        public List<SupplierModel> GetSuppliersActive() {
            return Mapper.Map<List<Supplier>, List<SupplierModel>>(service.GetSuppliersActive());
        }
        #endregion
    }
}
