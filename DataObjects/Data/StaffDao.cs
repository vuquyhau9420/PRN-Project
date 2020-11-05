using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data {
    public class StaffDao : IStaffDao {

        static DBHelpers db = new DBHelpers();

        public Staff CheckLogin(string username, string password) {
            string storeProcedure = "spCheckLogin";
            object[] parms = { "@STAFF_USERNAME", username, "@STAFF_PASSWORD", password };

            return db.Read(storeProcedure, make, parms).FirstOrDefault();
        }

        public void DeleteStaff(Staff staff) {
            throw new NotImplementedException();
        }

        public Staff GetStaff(int staffid) {
            throw new NotImplementedException();
        }

        public List<Staff> GetStaffs() {
            throw new NotImplementedException();
        }

        public void InsertStaff(Staff staff) {
            throw new NotImplementedException();
        }

        public void UpdateStaff(Staff staff) {
            throw new NotImplementedException();
        }

        static Func<IDataReader, Staff> make = reader => new Staff
        {
            Id = reader["staff_id"].AsId(),
            UserName = reader["staff_username"].AsString(),
            Password = reader["staff_password"].AsString(),
            FullName = reader["staff_fullname"].AsString(),
            CitizenIdentification = reader["staff_citizen_identification"].AsString(),
            Sex = reader["staff_sex"].AsBoolean(),
            Phone = reader["staff_phone"].AsString(),
            Address = reader["staff_address"].AsString(),
            BirthDay = reader["staff_birthday"].AsDateTime(),
            Role = reader["staff_role"].AsString(),
            Status = reader["staff_status"].AsBoolean()
        };
    }
}
