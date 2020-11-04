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
        List<Category> GetCategories();
        #endregion

        #region Product_Group
        List<ProductGroup> GetProductGroups(int category_id);
        #endregion

        #region Product
        List<Product> GetProducts(string productGroupId);
        #endregion
    }
}
