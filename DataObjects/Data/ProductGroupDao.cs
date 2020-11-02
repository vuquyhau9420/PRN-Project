using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data {
    public class ProductGroupDao : IProductGroupDao {

        static DBHelpers db = new DBHelpers();

        public string GetName(string productGroupId) {
            throw new NotImplementedException();
        }
        public List<ProductGroup> GetProductGroups(int category_id) {
            string storeProcedure = "spGetProductGroup";
            object[] parms = { "@CATEGORY_ID", category_id };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        static Func<IDataReader, ProductGroup> make = reader => new ProductGroup
        {
            Id = reader["product_group_id"].AsString(),
            Name = reader["product_group_name"].AsString(),
            SupplierName = reader["supplier_name"].AsString(),
            ProductGroupCategory = reader["category_name"].AsString(),
            IsStocking = reader["product_group_stocking"].AsBoolean(),
            Status = reader["product_group_status"].AsBoolean()
        };
    }
}
