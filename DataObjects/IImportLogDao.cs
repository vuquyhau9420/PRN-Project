using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IImportLogDao {
        List<ImportLog> GetImportLogsByStaff(string staffId);

        List<ImportLog> GetImportLogsByProduct(string productId);
    }
}
