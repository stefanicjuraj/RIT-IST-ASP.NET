using Newtonsoft.Json;

namespace EmploymentApp.Models
{
    /// <summary>
    /// Represents the model for the employment page.
    /// </summary>
    public class EmploymentModel
    {
        /// <summary>
        /// Gets or sets the name of the employer.
        /// </summary>
        public string? Employer { get; set; }
        /// <summary>
        /// Gets or sets the name of the degree.
        /// </summary>
        public string? Degree { get; set; }
        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Gets or sets the name of the term.
        /// </summary>
        public string? Term { get; set; }

        /// <summary>
        /// Retrieves the view model for the employment page asynchronously.
        /// </summary>
        /// <returns>The view model for the employment page.</returns>
        public static async Task<EmploymentViewModel?> GetViewModelAsync()
        {
            // Retrieves the JSON data from the about page API.
            // Deserializes the JSON data into a Model object.
            // Creates an AboutViewModel object
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/employment/employmentTable");
            return JsonConvert.DeserializeObject<EmploymentViewModel>(json);
        }
    }
}