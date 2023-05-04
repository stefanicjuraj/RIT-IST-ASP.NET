using Newtonsoft.Json;

namespace GraduateApp.Models
{
    /// <summary>
    /// Represents the model for the graduate page.
    /// </summary>
    public class GraduateModel
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
        /// Retrieves the view model for the graduate page asynchronously.
        /// </summary>
        /// <returns>The view model for the graduate page.</returns>
        public static async Task<GraduateViewModel?> GetViewModelAsync()
        {
            // Retrieves the JSON data from the about page API.
            // Deserializes the JSON data into a Model object.
            // Creates an AboutViewModel object
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/degrees/graduate");
            return JsonConvert.DeserializeObject<GraduateViewModel>(json);
        }
    }
}