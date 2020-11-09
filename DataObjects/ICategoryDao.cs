using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface ICategoryDao {
        List<Category> GetAllCategories();

        List<Category> GetCategoriesActive();

        bool DeleteCategory(int categoryId);

        bool AddCategory(string categoryName, bool status);

        bool CheckCategoryName(string categoryName);

        bool UpdateCategory(int categoryId, bool status);
    }
}
