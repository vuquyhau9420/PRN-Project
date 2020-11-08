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

        private static ProductGroupDao instance;

        public static ProductGroupDao GetInstance() {
            if (instance == null) {
                instance = new ProductGroupDao();
            }
            return instance;
        }

        static DBHelpers db = new DBHelpers();

        public string GetName(string productGroupId) {
            throw new NotImplementedException();
        }
        public List<ProductGroup> GetProductGroupsActive(int category_id) {
            string storeProcedure = "spGetProductGroupActive";
            object[] parms = { "@CATEGORY_ID", category_id };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public List<ProductGroup> GetAllProductGroups(int category_id) {
            string storeProcedure = "spGetAllProductGroup";
            object[] parms = { "@CATEGORY_ID", category_id };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public bool CheckStocking(string product_group_id) {
            string storeProcedure = "spCheckStocking";
            object[] parms = { "@PRODUCT_GROUP_ID", product_group_id };

            if (db.Count(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public bool UpdateStocking(string product_group_id, bool status) {
            string storeProcedure = "spUpdateStocking";
            object[] parms = { "@PRODUCT_GROUP_ID", product_group_id, "@STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
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
