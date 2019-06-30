using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class Charts
    {
        [Key]
        [ForeignKey(nameof(Demography))]
        [Required]
        public int DemographyID { get; set; }

        [StringLength(200, MinimumLength = 5)]
        public string Comorbidity { get; set; }

        [StringLength(150, MinimumLength = 3)]
        public string Medication { get; set; }

        [Required]
        [Range(1, 3)]
        public byte BpControl { get; set; }

        [Required]
        public bool FollowUp { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
