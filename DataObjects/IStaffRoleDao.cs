﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    interface IStaffRoleDao {
        string GetRole(string roleId);
    }
}
