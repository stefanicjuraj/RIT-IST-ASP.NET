namespace EmploymentApp.Models
{
    /// <summary>
    /// Represents the view model for the employment page.
    /// </summary>
    public class EmploymentViewModel
    {
        public EmploymentTable? EmploymentTable { get; set; }
    }

    public class EmploymentTable
    {
        public string? Title { get; set; }
        public EmploymentModel[]? ProfessionalEmploymentInformation { get; set; }
    }
}