

namespace Website_LDHai.BusinessFacade
{
    public class ResponseBase
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the acknowledge.
        /// </summary>
        /// <value>The acknowledge.</value>
        public AcknowledgeType Acknowledge { get; set; }
    }

    /// <summary>
    /// Enum AcknowledgeType
    /// </summary>
    public enum AcknowledgeType
    {
        /// <summary>
        /// The failure
        /// </summary>
        Failure,
        /// <summary>
        /// The success
        /// </summary>
        Success
    }
}
