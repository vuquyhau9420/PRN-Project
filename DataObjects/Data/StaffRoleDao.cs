using BusinessObject;
using DataLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Data
{
    public class StaffRoleDao : IStaffRoleDao
    {

        static DBHelpers db = new DBHelpers();

        private static StaffRoleDao instance;

        public static StaffRoleDao GetInstance()
        {
            if (instance == null)
            {
                instance = new StaffRoleDao();
            }
            return instance;
        }

        public List<StaffRole> GetAllRoles()
        {
            string storeProcedure = "spGetAllStaffRole";

            return db.Read(storeProcedure, make).ToList();
        }

        public string GetRole(string roleId)
        {
            throw new NotImplementedException();
        }

        static Func<IDataReader, StaffRole> make = reader => new StaffRole
        {
            Id = reader["role_id"].AsString(),
            Name = reader["role_name"].AsString()
        };
    }
}
