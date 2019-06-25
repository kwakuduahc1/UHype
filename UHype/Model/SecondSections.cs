using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class SecondSections
    {
        [Required]
        [ForeignKey(nameof(Demography))]
        [Key]
        public int DemographyID { get; set; }

        [Required]
        [Range(0, 2)]
        public byte HasPressure { get; set; }

        [Required]
        public bool Screening { get; set; }

        [Required]
        public bool Visit { get; set; }

        public bool Pharmacy { get; set; }

        public bool Admission { get; set; }

        public bool Forgotten { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Others { get; set; }

        [Required]
        public bool IsControlled { get; set; }

        [Required]
        public bool HasAdmitedIn12 { get; set; }

        [Required]
        public bool MeasureAtHome { get; set; }

        [Required]
        [Range(0, 2)]
        public byte RelativesHBP { get; set; }

        public bool Degree1 { get; set; }

        [Required]
        [Range(0, 2)]
        public byte ChronicDisease { get; set; }

        public bool Diabetes { get; set; }

        public bool CKD { get; set; }

        public bool HeartFail { get; set; }

        public bool Stroke { get; set; }

        public bool Dementia { get; set; }

        public bool AtrialFib { get; set; }

        public bool Prostate { get; set; }

        public bool CAD { get; set; }

        public bool HyperLip { get; set; }

        public bool Pain { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string OthersCND { get; set; }

        [Required]
        [Range(0, 3)]
        public byte HPTMeds { get; set; }

        public bool Amlodipine { get; set; }

        public bool Lisinopril { get; set; }

        public bool Losarta { get; set; }

        public bool Bendro { get; set; }

        public bool HCTZ { get; set; }

        public bool Atenolol { get; set; }

        public bool Bisoprolol { get; set; }

        public bool Methlydopa { get; set; }

        public bool Frusemide { get; set; }

        public bool Hydralazine { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string OtherMeds { get; set; }

        public bool HospitalNHIS { get; set; }

        public bool HospClosePharmNHIS { get; set; }

        public bool HospClosePharmLater { get; set; }

        public bool ClosePharmNHIS { get; set; }

        public bool HospitalFee { get; set; }

        [Required]
        [Range(0, 2)]
        public byte LabWork { get; set; }

        [Range(0, 2)]
        public byte HasNHIS { get; set; }

        [Range(0, 2)]
        [Required]
        public byte CareFacilities { get; set; }

        [Range(0, 2)]
        [Required]
        public byte DoGetMedsFromAll { get; set; }
        [Range(0, 2)]
        [Required]
        public byte HasSpecialClinic { get; set; }

        [Range(0, 4)]
        [Required]
        public byte SameDoctor { get; set; }

        [Range(0, 4)]
        [Required]
        public byte DrTellState { get; set; }

        [Range(0, 4)]
        [Required]
        public byte StaffAdvise { get; set; }

        [Range(0, 4)]
        [Required]
        public byte RunOutMeds { get; set; }

        [Range(0, 4)]
        [Required]
        public byte MissAppointment { get; set; }

        [Range(0, 4)]
        [Required]
        public byte TakeDrugsBeforeVisit { get; set; }

        [Range(1, 18)]
        [Required]
        public byte HospTime { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
