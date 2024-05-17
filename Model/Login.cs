using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class Login
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

}
