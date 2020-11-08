using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface ISupplierDao {
        List<Supplier> GetAllSuppliers();

        List<Supplier> GetSuppliersActive();
    }
}
