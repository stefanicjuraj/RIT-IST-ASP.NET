using Newtonsoft.Json;
using AboutApp.Models;

/// <summary>
/// Represents the model for the about page.
/// </summary>
public class AboutModel
{
    /// <summary>
    /// Gets or sets the title of the about page.
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the description of the about page.
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the quote
    /// </summary>
    [JsonProperty("quote")]
    public string? Quote { get; set; }

    /// <summary>
    /// Gets or sets the quoteauthor
    /// </summary>
    [JsonProperty("quoteAuthor")]
    public string? QuoteAuthor { get; set; }

    /// <summary>
    /// Retrieves the view model for the about page asynchronously.
    /// </summary>
    /// <returns>The view model for the about page.</returns>
    public static async Task<AboutViewModel?> GetViewModelAsync()
    {
        // Retrieves the JSON data from the about page API.
        // Deserializes the JSON data into a Model object.
        // Creates an AboutViewModel object
        string json = await new HttpClient().GetStringAsync(
            "http://ist.rit.edu/api/about");

        // Deserializes the JSON data into an AboutModel object.
        var model = JsonConvert.DeserializeObject<AboutModel>(json);
        // Creates an AboutViewModel object with the About property set to an array containing the AboutModel object.
        var viewModel = new AboutViewModel { About = new[] { model } };

        return viewModel;
    }
}