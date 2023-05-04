using Newtonsoft.Json;

namespace FacultyApp.Models
{
    /// <summary>
    /// Represents the model for the faculty page.
    /// </summary>
    public class FacultyModel
    {
        /// <summary>
        /// Gets or sets the imagepath.
        /// </summary>
        public string? imagePath { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Retrieves the view model for the faculty page asynchronously.
        /// </summary>
        /// <returns>The view model for the faculty page.</returns>
        public static async Task<FacultyViewModel?> GetViewModelAsync()
        {
            // Retrieves the JSON data from the about page API.
            // Deserializes the JSON data into a Model object.
            // Creates an AboutViewModel object
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/people/faculty");
            return JsonConvert.DeserializeObject<FacultyViewModel>(json);
        }
    }



}
