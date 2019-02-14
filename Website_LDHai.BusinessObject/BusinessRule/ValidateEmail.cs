using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_LDHai.BusinessObject.BusinessRule
{
    public class ValidateEmail : ValidateRegex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmail"/> class.
        /// </summary>
        /// <param name="propertyName">The property name to which rule applies.</param>
        public ValidateEmail(string propertyName) :
            base(propertyName, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
        {
            ErrorMessage = propertyName + " is not a valid email address";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmail"/> class.
        /// </summary>
        /// <param name="propertyName">The property name to which rule applies.</param>
        /// <param name="errorMessage">The error message.</param>
        public ValidateEmail(string propertyName, string errorMessage) :
            this(propertyName)
        {
            ErrorMessage = errorMessage;
        }
    }
}
