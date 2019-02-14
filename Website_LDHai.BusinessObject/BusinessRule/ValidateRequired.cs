using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_LDHai.BusinessObject.BusinessRule
{
    public class ValidateRequired : BusinessRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateRequired"/> class.
        /// </summary>
        /// <param name="propertyName">The property name to which rule applies.</param>
        public ValidateRequired(string propertyName)
            : base(propertyName)
        {
            ErrorMessage = propertyName + " is a required field.";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateRequired"/> class.
        /// </summary>
        /// <param name="propertyName">The property name to which rule applies.</param>
        /// <param name="errorMessage">The error message.</param>
        public ValidateRequired(string propertyName, string errorMessage)
            : base(propertyName)
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
            try
            {
                return GetPropertyValue(businessObject).ToString().Length > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
