namespace CoopApp.Models
{
    /// <summary>
    /// Represents the view model for the coop page.
    /// </summary>
    public class CoopViewModel
    {
        public CoopTable? CoopTable { get; set; }
    }

    public class CoopTable
    {
        public string? Title { get; set; }
        public CoopModel[]? CoopInformation { get; set; }
    }

}