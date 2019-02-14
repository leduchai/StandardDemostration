using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_LDHai.BusinessObject.BusinessRule
{
    public abstract class BusinessRule
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName">The property name to which rule applies.</param>
        protected BusinessRule(string propertyName)
        {
            PropertyName = propertyName;
            ErrorMessage = propertyName + " is not valid";
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="propertyName">The property name to which rule applies.</param>
        /// <param name="errorMessage">The error message.</param>
        protected BusinessRule(string propertyName, string errorMessage)
            : this(propertyName)
        {
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Validation method. To be implemented in derived classes.
        /// </summary>
        /// <param name="businessObject"></param>
        /// <returns></returns>
        public abstract bool Validate(BusinessObject businessObject);

        /// <summary>
        /// Gets value for given business object's property using reflection.
        /// </summary>
        /// <param name="businessObject">The business object.</param>
        /// <returns></returns>
        protected object GetPropertyValue(BusinessObject businessObject)
        {
            return businessObject.GetType().GetProperty(PropertyName).GetValue(businessObject, null);
        }
    }
}
