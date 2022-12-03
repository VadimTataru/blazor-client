using System.ComponentModel.DataAnnotations;

namespace blazor_client.Models
{
    public class LoginUserModel
    {
        [Required]
        public string login { get; set; }

        [Required]
        public string password { get; set; }
    }
}
