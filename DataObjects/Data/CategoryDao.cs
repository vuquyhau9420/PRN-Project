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

        public string GetCategoryName(string categoryId) {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories() {
            string storeProcedure = "spGetAllCategories";
            return db.Read(storeProcedure, make).ToList();
        }

        public List<Category> GetCategoriesActive() {
            string storeProcedure = "spGetCategoriesActive";
            return db.Read(storeProcedure, make).ToList();
        }

        static Func<IDataReader, Category> make = reader => new Category
        {
            Id = reader["category_id"].AsId(),
            Name = reader["category_name"].AsString(),
            Status = reader["category_status"].AsBoolean()
        };
    }
}
