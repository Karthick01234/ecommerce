using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public int Mobile { get; set; }
    }
}
