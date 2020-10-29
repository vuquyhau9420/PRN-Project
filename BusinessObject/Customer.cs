using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    class Customer : BusinessObject {
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public float Points { get; set; }
        public string Email { get; set; }
    }
}
