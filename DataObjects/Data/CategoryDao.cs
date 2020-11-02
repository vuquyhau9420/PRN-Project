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

        static DBHelpers db = new DBHelpers();

        public string GetCategoryName(string categoryId) {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories() {
            string storeProcedure = "spGetCategorys";
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
