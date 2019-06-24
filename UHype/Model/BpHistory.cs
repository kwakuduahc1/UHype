using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class BpHistory
    {
        [Key]
        [Required]
        [ForeignKey(nameof(Demography))]
        public int DemographyID { get; set; }

        public double Systole { get; set; }

        public double Diastole { get; set; }

        public DateTime DateChecked { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
