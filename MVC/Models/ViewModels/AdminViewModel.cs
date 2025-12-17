using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class AdminViewModel
    {
        //Kullanıcı adı, şifre ve beni hatırla propertyleri tanımla. statik değil. statik değerler AdminController'da olacak. Çünkü sabit bir degere attirbute vermek mantıklı değil.
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
