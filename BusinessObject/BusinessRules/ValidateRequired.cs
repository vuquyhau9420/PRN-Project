using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessRules {
    class ValidateRequired : BusinessRule {

        public ValidateRequired(string propertyName) : base(propertyName) {
            Error = propertyName + " is required.";
        }

        public ValidateRequired(string propertyName, string error) : this(propertyName) {
            Error = error;
        }
        public override bool Validate(BusinessObject businessObject) {
            string s = GetPropertyValue(businessObject).ToString();
            if (s.Trim().Length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
