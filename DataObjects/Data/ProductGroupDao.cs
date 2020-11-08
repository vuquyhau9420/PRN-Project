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

        public bool CheckStocking(string productGroupId) {
            string storeProcedure = "spCheckStocking";
            object[] parms = { "@PRODUCT_GROUP_ID", productGroupId };

            if (db.Count(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public bool UpdateStocking(string productGroupId, bool status) {
            string storeProcedure = "spUpdateStocking";
            object[] parms = { "@PRODUCT_GROUP_ID", productGroupId, "@STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public List<ProductGroup> GetProductGroupsActiveBaseCategory(int categoryId) {
            string storeProcedure = "spGetProductGroupActiveBaseCategory";
            object[] parms = { "@CATEGORY_ID", categoryId };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public List<ProductGroup> GetAllProductGroupsBaseCategory(int categoryId) {
            string storeProcedure = "spGetAllProductGroupBaseCategory";
            object[] parms = { "@CATEGORY_ID", categoryId };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public List<ProductGroup> GetProductGroupsActiveBaseSupplier(int supplierId) {
            string storeProcedure = "spGetProductGroupActiveBaseSupplier";
            object[] parms = { "@SUPPLIER_ID", supplierId };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public List<ProductGroup> GetAllProductGroupsBaseSupplier(int supplierId) {
            string storeProcedure = "spGetAllProductGroupBaseSupplier";
            object[] parms = { "@SUPPLIER_ID", supplierId };
            return db.Read(storeProcedure, make, parms).ToList();
        }

        public bool InsertProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status) {
            string storeProcedure = "spInsertProductGroup";
            object[] parms = { "@PRODUCT_GROUP_ID", productGroupId, "@PRODUCT_GROUP_NAME", productGroupName,
                               "@SUPPLIER_ID", supplierId, "@PRODUCT_GROUP_CATEGORY", categoryId,
                                "@PRODUCT_GROUP_STOCKING", isStocking, "@PRODUCT_GROUP_STATUS", status };
            if (db.Update(storeProcedure, parms) > 0) {
                return true;
            }
            return false;
        }

        public bool UpdateProductGroup(string product_group_id, string product_group_name, int supplier_id, int category_id, bool is_stocking, bool status) {
            throw new NotImplementedException();
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
