// ErrorViewModel.cs
// Represents the data model used for displaying error information in the application.
namespace StudentManagementSystem.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        /// Indicates whether the RequestId should be shown.
        /// Returns true if RequestId is not null or empty.
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
