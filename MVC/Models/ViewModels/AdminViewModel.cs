using com.sun.org.apache.xalan.@internal.xsltc.compiler.util;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class AdminViewModel
    {
        [Required(ErrorMessage ="Geçersiz giriş yaptınız.")]
        public static string username = "admin";

        [Required(ErrorMessage = "Geçersiz giriş yaptınız.")]
        [PasswordPropertyText]
        public static string password = "123";
    }
}
