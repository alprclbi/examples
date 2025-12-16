using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class AdminViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
