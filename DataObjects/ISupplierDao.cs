using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    interface ISupplierDao {
        string GetSupplierName(string supplierId);

        Supplier GetSupplierInfo(string supplierId);
    }
}
