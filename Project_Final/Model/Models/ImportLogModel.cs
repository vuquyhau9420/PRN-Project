using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final.Model.Models {
    class ImportLogModel {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string ProductId { get; set; }
        public int ImportQuantity { get; set; }
        public DateTime ImportTime { get; set; }

        // Parent
        public StaffModel Staff { get; set; }
        public ProductModel Product { get; set; }
    }
}
