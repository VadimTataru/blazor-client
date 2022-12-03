using System.ComponentModel.DataAnnotations;

namespace blazor_client.Models 
{
    public class RegisterUserModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Минимальная длина логина 3 символа")]
        public string login { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Минимальная длина пароля 6 символов")]
        public string password { get; set; }

        [Required]
        public string email { get; set; }
    }
}
