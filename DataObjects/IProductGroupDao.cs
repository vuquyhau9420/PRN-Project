using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IProductGroupDao {
        string GetName(string productGroupId);

        List<ProductGroup> GetProductGroups(int category_id);
    }
}
