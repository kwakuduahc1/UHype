using System.ComponentModel.DataAnnotations;

namespace UHype.Model.ViewModels
{
    public class RegisterVm
    {
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6)]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool RememberMe { get; set; }

        internal AppUsers Transform() => new AppUsers { UserName = UserName, Password = Password, Team= Team, Facility= Facility };


        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Team { get; set; }

        [Required]
        [StringLength(20)]
        public string Facility { get; set; }
    }
}
