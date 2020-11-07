﻿using BusinessObject;
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
        List<Category> GetCategories();
        #endregion

        #region Product_Group
        List<ProductGroup> GetProductGroups(int category_id);
        #endregion

        #region Product
        List<Product> GetProducts(string productGroupId);
        bool UpdateProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);
        bool InsertProduct(string productGroupId, string productId, string productName, int quantity, double importPrice, double salePrice, string description, string image, bool status);
        bool DeleteProduct(string productId);
        #endregion
    }
}
