using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IStaffRoleDao {
        string GetRole(string roleId);

        List<StaffRole> GetAllRoles();
    }
}
