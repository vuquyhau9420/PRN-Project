using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IProductGroupDao {

        List<ProductGroup> GetProductGroupsActive(int category_id);

        List<ProductGroup> GetAllProductGroups(int category_id);

        bool CheckStocking(string product_group_id);

        bool UpdateStocking(string product_group_id, bool status);
    }
}
