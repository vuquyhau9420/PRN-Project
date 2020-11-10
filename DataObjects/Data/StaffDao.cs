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

        private static StaffDao instance;

        public static StaffDao GetInstance() {
            if (instance == null) {
                instance = new StaffDao();
            }
            return instance;
        }

        public Staff CheckLogin(string username, string password) {
            string storeProcedure = "spCheckLogin";
            object[] parms = { "@STAFF_USERNAME", username, "@STAFF_PASSWORD", password };

            return db.Read(storeProcedure, make, parms).FirstOrDefault();
        }

        public bool DeleteStaff(Staff staff) {
            throw new NotImplementedException();
        }

        public Staff GetStaff(int staffid) {
            throw new NotImplementedException();
        }

        public List<Staff> GetStaffs() {
            string storeProcedure = "spGetAllStaff";

            return db.Read(storeProcedure, make).ToList();
        }
        
        public bool InsertStaff(Staff staff) {
            string storeProcedure = "spInsertStaff";
            object[] parms = { "@Username", staff.UserName, 
                               "@Password", staff.Password, 
                               "@FulName", staff.FullName, 
                               "@Citizen_identification", staff.CitizenIdentification, 
                               "@Sex", staff.Sex, 
                               "@Phone", staff.Phone, 
                               "@Address", staff.Address, 
                               "@Birthday", staff.BirthDay, 
                               "@Role", staff.Role, 
                               "@Status", staff.Status, 
                               "@Image", staff.Image };
            if(db.Insert(storeProcedure, parms) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateStaff(Staff staff) {
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
            Status = reader["staff_status"].AsBoolean(),
            Image = reader["staff_image"].AsString()
        };
    }
}
