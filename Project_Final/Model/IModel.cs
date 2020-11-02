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
        List<CategoryModel> GetCategories();
        #endregion

        #region Product Group
        List<ProductGroupModel> GetProductGroups(int category_id);
        #endregion
    }
}
