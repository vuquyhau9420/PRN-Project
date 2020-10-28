﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessRules {
    public abstract class BusinessRule {
        public string Property { get; set; }
        public string Error { get; set; }

        public BusinessRule(string property) {
            Property = property;
            Error = property + " is not valid.";
        }

        public BusinessRule(string property, string error) : this(property) {
            Error = error;
        }

        public abstract bool Validate(BusinessObject businessObject);

        protected object GetPropertyValue(BusinessObject businessObject) {
            return businessObject.GetType().GetProperty(Property).GetValue(businessObject, null);
        }
    }
}
