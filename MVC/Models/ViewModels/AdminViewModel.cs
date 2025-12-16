using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class AdminViewModel
    {
        //Kullanıcı adı, şifre ve beni hatırla propertyleri tanımla. statik değil. statik değerler AminController'da olacak. Çünkü Attirubute verilmiyor.
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
