using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class AppUsers : IdentityUser
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public override string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6)]
        [NotMapped]
        public string Password { get; set; }

        [Required]
        [StringLength(10, MinimumLength =3)]
        public string Team { get; set; }

        [Required]
        [StringLength(20)]
        public string Facility { get; set; }
    }
}
