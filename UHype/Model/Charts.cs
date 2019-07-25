using System;
using System.ComponentModel;
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

        [DefaultValue(false)]
        public bool Diabetes { get; set; }

        [DefaultValue(false)]
        public bool CKD { get; set; }

        [DefaultValue(false)]
        public bool HeartFail { get; set; }

        [DefaultValue(false)]
        public bool Stroke { get; set; }

        [DefaultValue(false)]
        public bool Dementia { get; set; }

        [DefaultValue(false)]
        public bool AtrialFib { get; set; }

        [DefaultValue(false)]
        public bool Prostate { get; set; }

        public bool CAD { get; set; }

        [DefaultValue(false)]
        public bool HyperLip { get; set; }

        [DefaultValue(false)]
        public bool Pain { get; set; }


        [DefaultValue(false)]
        public bool Hypertensives { get; set; }

        [DefaultValue(false)]
        public bool Diabetics { get; set; }

        [DefaultValue(false)]
        public bool Platelets { get; set; }

        [DefaultValue(false)]
        public bool Cholesterol { get; set; }

        public string OtherMeds { get; set; }

        public DateTime LabDate { get; set; }

        public double LabCholesterol { get; set; }

        [DefaultValue(false)]
        public double HDL { get; set; }

        [DefaultValue(false)]
        public double LDL { get; set; }

        [DefaultValue(false)]
        public double Trigs { get; set; }

        [DefaultValue(false)]
        public double BUN { get; set; }

        [DefaultValue(false)]
        public double Creatinine { get; set; }

        [Required]
        public bool BpControl { get; set; }

        [Required]
        public bool FollowUp { get; set; }

        [DefaultValue(false)]
        public bool RecordedPulseBp { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
