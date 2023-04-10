using System.ComponentModel.DataAnnotations;

namespace Shop_web_app.Models
{
    public class LogIn
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
