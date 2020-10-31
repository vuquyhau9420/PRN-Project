using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data {
    public class StaffDao : IStaffDao {

        static DBHelpers db = new DBHelpers();

        const string ACTIVE_STAFF_STATUS = "True";

        public Staff CheckLogin(string username, string password) {
            //string sql = "SELECT staff_id, staff_username, staff_password, staff_fullname, " +
            //    "staff_citizen_identification, staff_sex, staff_phone, staff_address, " +
            //    "staff_birthday, staff_role, staff_status " +
            //    "FROM staff " +
            //    "WHERE staff_username = @STAFF_USERNAME " +
            //    "AND staff_password = @STAFF_PASSWORD AND staff_status = @STAFF_STATUS";
            string storeProcedure = "spCheckLogin";
            object[] parms = { "@STAFF_USERNAME", username, "@STAFF_PASSWORD", password };

            return db.Read(storeProcedure, make, parms).First();
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
