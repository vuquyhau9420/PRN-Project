using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    public interface IPromotionDao {
        Promotion GetPromotion(string promotionId);
    }
}
