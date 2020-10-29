using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    class Promotion : BusinessObject {
        public string Id { get; set; }
        public int Value { get; set; }
        public DateTime EndTime { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        // Parent

        public PromotionStatus PromotionStatus { get; set; }
    }
}
