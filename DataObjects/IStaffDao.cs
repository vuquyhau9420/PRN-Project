using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataObjects {
    interface IStaffDao {
        Staff GetStaff(int staffid);

        List<Staff> GetStaffs();

        void InsertStaff(Staff staff);

        void UpdateStaff(Staff staff);

        void DeleteStaff(Staff staff);
    }
}
