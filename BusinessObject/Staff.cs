﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    public class Staff : BusinessObject {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string CitizenIdentification { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }

        public string Image { get; set; }

        // Parent
        public StaffRole StaffRole { get; set; }
    }
}
