using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    class PromotionModel {
        public string Id { get; set; }
        public int Value { get; set; }
        public DateTime EndTime { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        // Parent
        public PromotionStatusModel PromotionStatus { get; set; }
    }
}
