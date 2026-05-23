using System.ComponentModel.DataAnnotations;

namespace SmartQrGenerator.Web.Models
{
    public class QrRequest
    {
        [Required(ErrorMessage = "Please enter a link.")]
        [Url(ErrorMessage = "Please enter a valid URL like https://example.com")]
        [RegularExpression(@"^https?:\/\/.+", ErrorMessage = "URL must start with http:// or https://")]
        public string? Url { get; set; }

        public string? QrCodeBase64 { get; set; }
    }
}
