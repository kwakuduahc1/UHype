using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class BpHistory
    {
        [Key]
        [ForeignKey(nameof(Demography))]
        public Guid DemographyID { get; set; }

        public double Systole { get; set; }

        public double Diastole { get; set; }

        public DateTime DateChecked { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
