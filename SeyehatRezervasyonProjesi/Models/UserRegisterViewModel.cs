using System.ComponentModel.DataAnnotations;

namespace SeyehatRezervasyonProjesi.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Ad Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen SoyAd Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Ad Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresi Giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Aynı Değil")]
        public string ConfirmPassword { get; set; }
    }
}
