using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataObjects {
    public interface IStaffDao {
        Staff CheckLogin(string username, string password);

        Staff GetStaff(int staffid);

        List<Staff> GetStaffs();

        bool InsertStaff(Staff staff);

        bool UpdateStaff(Staff staff);

        bool DeleteStaff(Staff staff);
    }
}
