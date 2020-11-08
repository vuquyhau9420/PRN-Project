using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data {
    public class SupplierDao : ISupplierDao {
        private static SupplierDao instance;

        static DBHelpers db = new DBHelpers();

        public static SupplierDao GetInstance() {
            if (instance == null) {
                instance = new SupplierDao();
            }
            return instance;
        }

        public List<Supplier> GetAllSuppliers() {
            string storeProcedure = "spGetAllSupplier";
            return db.Read(storeProcedure, make).ToList();
        }

        public List<Supplier> GetSuppliersActive() {
            string storeProcedure = "spGetSupplierActive";
            return db.Read(storeProcedure, make).ToList();
        }

        static Func<IDataReader, Supplier> make = reader => new Supplier
        {
            Id = reader["supplier_id"].AsId(),
            Name = reader["supplier_name"].AsString(),
            Phone = reader["supplier_phone"].AsString(),
            Address = reader["supplier_address"].AsString(),
            Status = reader["supplier_status"].AsBoolean()
        };
    }
}
