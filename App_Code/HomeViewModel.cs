using System.ComponentModel.DataAnnotations;

namespace Emaid.Models
{
    public class HomeViewModel
    {
        [Required]
        [EmailAddress]
        public string Email     { get; set; }

        public string Subject   { get; set; }

        public string Body      { get; set; }
    }
}