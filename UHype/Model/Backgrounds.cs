using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class Demography
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DemographyID { get; set; }

        public byte IsSelf { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Facility { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 4)]
        public string Age { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Marital { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Religion { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Ethnicity { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Occupation { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Education { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual SecondSections SecondSections { get; set; }

        public virtual Anthropometries Anthropometries { get; set; }

        public virtual BpHistory BpHistory { get; set; }

        public virtual ICollection<Charts> Charts { get; set; }

        public virtual Labs Labs { get; set; }

        public virtual QualityAssessments QualityAssessments { get; set; }

        public virtual SocioFactors SocioFactors { get; set; }
    }
}
