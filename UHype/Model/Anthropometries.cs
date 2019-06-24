using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class Anthropometries
    {
        [Key]
        [ForeignKey(nameof(Demography))]
        public int DemographyID { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public double Bmi { get; set; }

        public double MUAC { get; set; }

        public double AbdCirc { get; set; }

        public double Systole { get; set; }

        public double Diastole { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
