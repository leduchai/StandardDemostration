using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Website_LDHai.BusinessObject.BusinessRule
{
    public class ValidateRegex : BusinessRule
    {
        protected string Pattern { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateRegex"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="pattern">The pattern.</param>
        public ValidateRegex(string propertyName, string pattern)
            : base(propertyName)
        {
            Pattern = pattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateRegex"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="pattern">The pattern.</param>
        public ValidateRegex(string propertyName, string errorMessage, string pattern)
            : this(propertyName, pattern)
        {
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Validation method. To be implemented in derived classes.
        /// </summary>
        /// <param name="businessObject"></param>
        /// <returns></returns>
        public override bool Validate(BusinessObject businessObject)
        {
            return Regex.Match(GetPropertyValue(businessObject).ToString(), Pattern).Success;
        }
    }
}
