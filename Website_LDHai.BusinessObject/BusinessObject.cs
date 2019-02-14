using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website_LDHai.BusinessObject.BusinessRule;

namespace Website_LDHai.BusinessObject
{
    public abstract class BusinessObject
    {
        /// <summary>
        /// Default value for version number (used in LINQ's optimistic concurrency)
        /// </summary>
        protected static readonly string VersionDefault = "NotSet";

        // List of business rules
        private readonly List<BusinessRule.BusinessRule> _businessRules = new List<BusinessRule.BusinessRule>();

        // List of validation errors (following validation failure)

        /// <summary>
        /// Gets list of validations errors.
        /// </summary>
        public List<string> ValidationErrors { get; } = new List<string>();

        /// <summary>
        /// Adds a business rule to the business object.
        /// </summary>
        /// <param name="rule"></param>
        protected void AddRule(BusinessRule.BusinessRule rule)
        {
            _businessRules.Add(rule);
        }

        /// <summary>
        /// Determines whether business rules are valid or not.
        /// Creates a list of validation errors when appropriate.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            ValidationErrors.Clear();

            foreach (var rule in _businessRules)
            {
                if (rule.Validate(this)) continue;
                isValid = false;
                ValidationErrors.Add(rule.ErrorMessage);
            }
            return isValid;
        }
    }
}
