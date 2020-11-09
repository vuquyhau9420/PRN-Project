using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data {
    public class CategoryDao : ICategoryDao {

        private static CategoryDao instance;

        static DBHelpers db = new DBHelpers();

        public static CategoryDao GetInstance() {
            if (instance == null) {
                instance = new CategoryDao();
            }
            return instance;
        }

        public List<Category> GetAllCategories() {
            string storeProcedure = "spGetAllCategories";
            return db.Read(storeProcedure, make).ToList();
        }

        public List<Category> GetCategoriesActive() {
            string storeProcedure = "spGetCategoriesActive";
            return db.Read(storeProcedure, make).ToList();
        }

        public bool DeleteCategory(int categoryId) {
            string storeProcedure = "spDeleteCategory";
            object[] parms = { "@CATEGORY_ID", categoryId };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public bool AddCategory(string categoryName, bool status) {
            string storeProcedure = "spInsertCategory";
            object[] parms = { "@CATEGORY_NAME", categoryName, "@CATEGORY_STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public bool CheckCategoryName(string categoryName) {
            string storeProcedure = "spCheckCategoryName";
            object[] parms = { "@CATEGORY_NAME", categoryName };
            if (db.Read(storeProcedure, make, parms).FirstOrDefault() != null) {
                return true;
            }
            return false;
        }

        public bool UpdateCategory(int categoryId, bool status) {
            string storeProcedure = "spUpdateCategory";
            object[] parms = { "@CATEGORY_ID", categoryId, "@CATEGORY_STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        static Func<IDataReader, Category> make = reader => new Category
        {
            Id = reader["category_id"].AsId(),
            Name = reader["category_name"].AsString(),
            Status = reader["category_status"].AsBoolean()
        };
    }
}
