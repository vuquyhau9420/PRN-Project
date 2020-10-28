using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessRules {
    class ValidateLength : BusinessRule {

        private int min;
        private int max;

        public ValidateLength(string propertyName, int min, int max) : base(propertyName) {
            this.min = min;
            this.max = max;
            Error = propertyName + " must be between " + this.min + " and " + this.max + " characters long.";
        }

        public ValidateLength(string propertyName, int min, int max, string error) : this(propertyName, min, max) {
            Error = error;
        }

        public override bool Validate(BusinessObject businessObject) {
            int length = GetPropertyValue(businessObject).ToString().Length;
            return length >= min && length <= max;
        }
    }
}
