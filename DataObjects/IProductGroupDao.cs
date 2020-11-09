using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IProductGroupDao {

        List<ProductGroup> GetProductGroupsActiveBaseCategory(int categoryId);

        List<ProductGroup> GetAllProductGroupsBaseCategory(int categoryId);

        List<ProductGroup> GetProductGroupsActiveBaseSupplier(int supplierId);

        List<ProductGroup> GetAllProductGroupsBaseSupplier(int supplierId);

        bool CheckStocking(string productGroupId);

        bool UpdateStocking(string productGroupId, bool status);

        bool InsertProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status);

        bool UpdateProductGroup(string productGroupId, string productGroupName, int supplierId, int categoryId, bool isStocking, bool status);

        bool DeleteProductGroup(string productGroupId);
    }
}
