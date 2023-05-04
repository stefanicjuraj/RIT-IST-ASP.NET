using Newtonsoft.Json;

namespace MinorApp.Models
{
    /// <summary>
    /// Represents the view model for the minor page.
    /// </summary>
    public class MinorModel
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Retrieves the view model for the minor page asynchronously.
        /// </summary>
        /// <returns>The view model for the minor page.</returns>
        public static async Task<MinorViewModel?> GetViewModelAsync()
        {
            // Retrieves the JSON data from the about page API.
            // Deserializes the JSON data into a Model object.
            // Creates an AboutViewModel object
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/Minor");
            return JsonConvert.DeserializeObject<MinorViewModel>(json);
        }
    }
}