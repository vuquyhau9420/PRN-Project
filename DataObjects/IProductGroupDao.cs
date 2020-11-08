using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IProductGroupDao {

        List<ProductGroup> GetProductGroupsActiveBaseCategory(int category_id);

        List<ProductGroup> GetAllProductGroupsBaseCategory(int category_id);

        List<ProductGroup> GetProductGroupsActiveBaseSupplier(int supplier_id);

        List<ProductGroup> GetAllProductGroupsBaseSupplier(int supplier_id);

        bool CheckStocking(string product_group_id);

        bool UpdateStocking(string product_group_id, bool status);
    }
}
