using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class StudentViewModel
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [DisplayName("Ad Soyad")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [EmailAddress(ErrorMessage ="E-potsa formatı doğru değildir")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [Range(18, 60, ErrorMessage = "Yaş 18 ile 60 arasında olmalıdır")]
        [DisplayName("Yaş")]
        public int? Age { get; set; }

    }
}
