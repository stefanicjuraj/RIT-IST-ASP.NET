// <summary>
/// Represents a model that is used to handle errors in the About.
/// </summary>
namespace AboutApp.Models
{
    public class ErrorAboutModel
    {
        /// <summary>
        /// Gets or sets the request ID associated with the error.
        /// </summary>
        /// <value>A string that represents the request ID associated with the error.</value>
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}