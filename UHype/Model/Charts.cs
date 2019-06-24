using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class Charts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChartsID { get; set; }

        [Required]
        [ForeignKey(nameof(Demography))]
        public int DemographyID { get; set; }

        [StringLength(200, MinimumLength = 5)]
        public string Comorbidity { get; set; }

        [StringLength(150, MinimumLength = 3)]
        public string Medication { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
