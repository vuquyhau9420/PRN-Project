using ActionService;
using AutoMapper;
using BusinessObject;
using Project_Final.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Mapper.CreateMap<StaffRole, StaffRoleModel>();
            Mapper.CreateMap<StaffRoleModel, StaffRole>();
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

        public List<CategoryModel> GetCategoriesActive() {
            return Mapper.Map<List<Category>, List<CategoryModel>>(service.GetCategoriesActive());
        }

        public bool DeleteCategory(int categoryId) {
            return service.DeleteCategory(categoryId);
        }

        public bool AddCategory(string categoryName, bool status) {
            return service.AddCategory(categoryName, status);
        }

        public bool CheckCategoryName(string categoryName) {
            return service.CheckCategoryName(categoryName);
        }

        public bool UpdateCategory(int categoryId, bool status) {
            return service.UpdateCategory(categoryId, status);
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

        public bool UpdateProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status) {
            return service.UpdateProductGroup(productGroupId, productGroupName, supplierId, categoryId, isStocking, status);
        }

        public bool DeleteProductGroup(string productGroupId) {
            return service.DeleteProductGroup(productGroupId);
        }
        #endregion

        #region Product
        public List<ProductModel> GetAllProducts(string productGroupId) {
            return Mapper.Map<List<Product>, List<ProductModel>>(service.GetAllProducts(productGroupId));
        }
        public List<ProductModel> GetProductsActive(string productGroupId) {
            return Mapper.Map<List<Product>, List<ProductModel>>(service.GetProductsActive(productGroupId));
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

        public bool DeleteProducts(string productGroupId) {
            return service.DeleteProducts(productGroupId);
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

        public List<StaffModel> GetAllStaff() {
            return Mapper.Map<List<Staff>, List<StaffModel>>(service.GetAllStaff());
        }

        public List<StaffRoleModel> GetAllStaffRole() {
            return Mapper.Map<List<StaffRole>, List<StaffRoleModel>>(service.GetAllStaffRole());
        }

        public bool InsertStaff(StaffModel staffModel)
        {
            //Staff staff = new Staff
            //{
            //    Address = staffModel.Address,
            //    BirthDay = staffModel.BirthDay,

            //};
            return service.InsertStaff(Mapper.Map<StaffModel,Staff>(staffModel));
        }
    }
}
