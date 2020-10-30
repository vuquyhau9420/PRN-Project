using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    public class ImportLog : BusinessObject {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string ProductId { get; set; }
        public int ImportQuantity { get; set; }
        public DateTime ImportTime { get; set; }

        // Parent
        public Staff Staff { get; set; }
        public Product Product { get; set; }
    }
}
