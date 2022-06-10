using System.ComponentModel.DataAnnotations;

namespace Training.A.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
