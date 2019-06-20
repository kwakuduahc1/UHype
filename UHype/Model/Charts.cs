using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class Charts
    {
        [Key]
        [Required]
        [ForeignKey(nameof(Demography))]
        public Guid DemographyID { get; set; }

        [StringLength(200, MinimumLength = 5)]
        public string Comorbidities { get; set; }

        [StringLength(150, MinimumLength = 3)]
        public string Medications { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
