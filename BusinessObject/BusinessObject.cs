using BusinessObject.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject {
    public abstract class BusinessObject {
        List<BusinessRule> rules = new List<BusinessRule>();

        List<string> errors = new List<string>();

        public List<string> Errors {
            get { return errors; }
        }

        protected void AddRule(BusinessRule rule) {
            rules.Add(rule);
        }

        public bool IsValid() {
            bool valid = true;

            errors.Clear();

            foreach (var businessRule in rules) {
                if (!businessRule.Validate(this)) {
                    valid = false;
                    errors.Add(businessRule.Error);
                }
            }
            return valid;
        }
    }
}
}
