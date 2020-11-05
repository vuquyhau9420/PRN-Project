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
        }

        #region Login
        public StaffModel Login(string username, string password) {
            return Mapper.Map<Staff, StaffModel>(service.CheckLogin(username, password));
        }
        #endregion

        #region Category
        public List<CategoryModel> GetCategories() {
            return Mapper.Map<List<Category>, List<CategoryModel>>(service.GetCategories());
        }
        #endregion

        #region Product Group
        public List<ProductGroupModel> GetProductGroups(int category_id) {
            return Mapper.Map<List<ProductGroup>, List<ProductGroupModel>>(service.GetProductGroups(category_id));
        }

        #endregion

        #region Product
        public List<ProductModel> GetProducts(string productGroupId) {
            return Mapper.Map<List<Product>, List<ProductModel>>(service.GetProducts(productGroupId));
        }
        public bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status) {
            return service.UpdateProduct(productGroupId, productId, productName, quantity, importPrice, salePrice, description, image, status);
        }
        #endregion
    }
}
