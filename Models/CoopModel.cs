using Newtonsoft.Json;

namespace CoopApp.Models
{
    /// <summary>
    /// Represents a Co-op model with employer, degree, city, and term properties.
    /// </summary>
    public class CoopModel
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
        /// Retrieves the view model for the coop page asynchronously.
        /// </summary>
        /// <returns>The view model for the coop page.</returns>
        public static async Task<CoopViewModel?> GetViewModelAsync()
        {
            // Retrieves the JSON data from the about page API.
            // Deserializes the JSON data into a Model object.
            // Creates an AboutViewModel object
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/employment/coopTable");
            return JsonConvert.DeserializeObject<CoopViewModel>(json);
        }
    }
}