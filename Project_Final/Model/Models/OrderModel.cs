using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    class OrderModel {
        public string Id { get; set; }
        public DateTime OrderDay { get; set; }
        public string CustomerPhone { get; set; }
        public double TotalPrice { get; set; }
        public double TotalPay { get; set; }
        public float Points { get; set; }
        public string PromotionId { get; set; }
        public int StaffId { get; set; }
        public List<OrderDetailModel> OrderDetails { get; set; }
    }
}
