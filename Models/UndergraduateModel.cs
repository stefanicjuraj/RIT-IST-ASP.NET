using Newtonsoft.Json;

namespace UndergraduateApp.Models
{
    /// <summary>
    /// Represents the model for the undergraduate page.
    /// </summary>
    public class UndergraduateModel
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Retrieves the view model for the undergraduate page asynchronously.
        /// </summary>
        /// <returns>The view model for the undergraduate page.</returns>
        public static async Task<UndergraduateViewModel?> GetViewModelAsync()
        {
            // Retrieves the JSON data from the about page API.
            // Deserializes the JSON data into a Model object.
            // Creates an AboutViewModel object
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/degrees/undergraduate");
            return JsonConvert.DeserializeObject<UndergraduateViewModel>(json);
        }
    }
}